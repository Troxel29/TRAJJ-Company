using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARRENTALBUSINESS
{
    public class BookingClass
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Identification { get; set; }
        public string Driverslicense { get; set; }
        public string Email { get; set; }
        public BookingClass(string firstname, string lastname, int age, string identification, string driverslicense, string email)
            {
                Firstname = firstname;
                Lastname = lastname;
                Age = age;
                Identification = identification;
                Driverslicense = driverslicense;
                Email = email;
		    }
        public override string ToString()
        {
            return $"Firstname: {Firstname}, Lastname: {Lastname}, Age: {Age}, Identification: {Identification}, Driverslicense: {Driverslicense}, Email: {Email}";
		}


	}
}
