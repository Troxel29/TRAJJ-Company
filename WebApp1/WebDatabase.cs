using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using UserAppLibrary;

namespace WebApp1
{
    public static class WebDatabase
    {
        private static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["CarRentalDB"].ConnectionString; }
        }

        public static void InitializeUsersTable()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' AND xtype='U')
                    CREATE TABLE Users (
                        Id INT PRIMARY KEY IDENTITY(1,1),
                        FirstName NVARCHAR(50) NOT NULL,
                        LastName NVARCHAR(50) NOT NULL,
                        Username NVARCHAR(50) NOT NULL UNIQUE,
                        PasswordHash NVARCHAR(512) NOT NULL,
                        Email NVARCHAR(100) NOT NULL UNIQUE,
                        PhoneNumber NVARCHAR(20),
                        Address NVARCHAR(255),
                        DateOfBirth DATE,
                        Role NVARCHAR(20) NOT NULL DEFAULT 'Customer',
                        CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
                    );", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool RegisterUser(string firstName, string lastName, string username, string password, string email, string phoneNumber, string address, DateTime dateOfBirth)
        {
            if (UsernameExists(username) || EmailExists(email))
                return false;

            string hash = HashPassword(password);
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Users (FirstName, LastName, Username, PasswordHash, Email, PhoneNumber, Address, DateOfBirth, Role)
                    VALUES (@FirstName, @LastName, @Username, @PasswordHash, @Email, @PhoneNumber, @Address, @DateOfBirth, 'Customer')", conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash", hash);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber ?? string.Empty);
                cmd.Parameters.AddWithValue("@Address", address ?? string.Empty);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                cmd.ExecuteNonQuery();
            }
            return true;
        }

        public static User ValidateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    SELECT Id, FirstName, LastName, Username, PasswordHash, Email, PhoneNumber, Address, DateOfBirth, Role
                    FROM Users WHERE Username = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedHash = reader["PasswordHash"].ToString();
                    if (!VerifyPassword(password, storedHash))
                        return null;

                    return new User(
                        (int)reader["Id"],
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        reader["Username"].ToString(),
                        reader["Email"].ToString(),
                        reader["PhoneNumber"].ToString(),
                        reader["Address"].ToString(),
                        reader["DateOfBirth"] != DBNull.Value ? (DateTime)reader["DateOfBirth"] : DateTime.MinValue,
                        reader["Role"].ToString()
                    );
                }
            }
            return null;
        }

        public static bool UsernameExists(string username)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public static bool EmailExists(string email)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        /// <summary>
        /// Hashes a password using PBKDF2 with a random salt.
        /// Returns a string in the format "iterations:salt:hash" (all base64-encoded).
        /// </summary>
        private static string HashPassword(string password)
        {
            const int iterations = 100000;
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            byte[] hash = DeriveKey(password, salt, iterations);
            return string.Format("{0}:{1}:{2}", iterations,
                Convert.ToBase64String(salt),
                Convert.ToBase64String(hash));
        }

        /// <summary>
        /// Verifies a plaintext password against a stored PBKDF2 hash.
        /// </summary>
        private static bool VerifyPassword(string password, string storedValue)
        {
            string[] parts = storedValue.Split(':');
            if (parts.Length != 3)
                return false;

            int iterations;
            if (!int.TryParse(parts[0], out iterations))
                return false;

            byte[] salt = Convert.FromBase64String(parts[1]);
            byte[] expectedHash = Convert.FromBase64String(parts[2]);
            byte[] actualHash = DeriveKey(password, salt, iterations);

            return SlowEquals(expectedHash, actualHash);
        }

        private static byte[] DeriveKey(string password, byte[] salt, int iterations)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                return pbkdf2.GetBytes(32);
            }
        }

        /// <summary>
        /// Constant-time byte array comparison to prevent timing attacks.
        /// </summary>
        private static bool SlowEquals(byte[] a, byte[] b)
        {
            int diff = a.Length ^ b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= a[i] ^ b[i];
            return diff == 0;
        }
    }
}
