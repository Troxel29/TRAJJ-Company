using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CARRENTALBUSINESS
{
    public static class Database
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["CarRentalDB"].ConnectionString;

        public static void InitializeDatabase()
        {
            using (SqlConnection conn = new SqlConnection(connectionString.Replace("Database=CarRental;", "")))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'CarRental') CREATE DATABASE CarRental;", conn);
                cmd.ExecuteNonQuery();
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //  Cars table
                SqlCommand cmd = new SqlCommand(@"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Cars' AND xtype='U')
                    CREATE TABLE Cars (
                        Id INT PRIMARY KEY IDENTITY(1,1),
                        Model NVARCHAR(100),
                        Year INT,
                        PricePerDay DECIMAL(10,2),
                        IsAvailable BIT,
                        ImagePath NVARCHAR(255)
                    );", conn);
                cmd.ExecuteNonQuery();

                //  Bookings table
                cmd = new SqlCommand(@"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Bookings' AND xtype='U')
                    CREATE TABLE Bookings (
                        Id INT PRIMARY KEY IDENTITY(1,1),
                        Firstname NVARCHAR(50),
                        Lastname NVARCHAR(50),
                        Age INT,
                        Identification NVARCHAR(50),
                        Driverslicense NVARCHAR(50),
                        Email NVARCHAR(100),
                        CarId INT,
                        PickupDate DATETIME,
                        DropoffDate DATETIME,
                        FOREIGN KEY (CarId) REFERENCES Cars(Id)
                    );", conn);
                cmd.ExecuteNonQuery();

                //  sample cars until we have real cars
                cmd = new SqlCommand("IF NOT EXISTS (SELECT * FROM Cars) INSERT INTO Cars (Model, Year, PricePerDay, IsAvailable, ImagePath) VALUES ('Toyota Camry', 2020, 50.00, 1, 'car1.jpg'), ('Honda Civic', 2019, 45.00, 1, 'car2.jpg'), ('Ford Mustang', 2021, 80.00, 1, 'car3.jpg');", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cars", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cars.Add(new Car(
                        (int)reader["Id"],
                        reader["Model"].ToString(),
                        (int)reader["Year"],
                        (decimal)reader["PricePerDay"],
                        (bool)reader["IsAvailable"],
                        reader["ImagePath"].ToString()
                    ));
                }
            }
            return cars;
        }

        public static void SaveBooking(BookingClass booking)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Bookings (Firstname, Lastname, Age, Identification, Driverslicense, Email, CarId, PickupDate, DropoffDate) VALUES (@Firstname, @Lastname, @Age, @Identification, @Driverslicense, @Email, @CarId, @PickupDate, @DropoffDate)", conn);
                cmd.Parameters.AddWithValue("@Firstname", booking.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", booking.Lastname);
                cmd.Parameters.AddWithValue("@Age", booking.Age);
                cmd.Parameters.AddWithValue("@Identification", booking.Identification);
                cmd.Parameters.AddWithValue("@Driverslicense", booking.Driverslicense);
                cmd.Parameters.AddWithValue("@Email", booking.Email);
                cmd.Parameters.AddWithValue("@CarId", booking.CarId);
                cmd.Parameters.AddWithValue("@PickupDate", booking.PickupDate);
                cmd.Parameters.AddWithValue("@DropoffDate", booking.DropoffDate);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<BookingClass> GetBookings()
        {
            List<BookingClass> bookings = new List<BookingClass>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Bookings", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bookings.Add(new BookingClass(
                        (int)reader["Id"],
                        reader["Firstname"].ToString(),
                        reader["Lastname"].ToString(),
                        (int)reader["Age"],
                        reader["Identification"].ToString(),
                        reader["Driverslicense"].ToString(),
                        reader["Email"].ToString(),
                        (int)reader["CarId"],
                        (DateTime)reader["PickupDate"],
                        (DateTime)reader["DropoffDate"]
                    ));
                }
            }
            return bookings;
        }
    }
}