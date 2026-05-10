using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAppLibrary
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Role { get; set; }

        public User(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = "Customer";
        }

        public User(int id, string firstName, string lastName, string username, string email, string phoneNumber, string address, DateTime dateOfBirth, string role)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.Role = role;
        }
    }
}
