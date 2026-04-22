using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARRENTALBUSINESS
{
    public class BookingClass
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Identification { get; set; }
        public string Driverslicense { get; set; }
        public string Email { get; set; }
        public int CarId { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime DropoffDate { get; set; }

        public BookingClass(int id, string firstname, string lastname, int age, string identification, string driverslicense, string email, int carId, DateTime pickupDate, DateTime dropoffDate)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Identification = identification;
            Driverslicense = driverslicense;
            Email = email;
            CarId = carId;
            PickupDate = pickupDate;
            DropoffDate = dropoffDate;
        }

        public BookingClass(string firstname, string lastname, int age, string identification, string driverslicense, string email, int carId, DateTime pickupDate, DateTime dropoffDate)
            : this(0, firstname, lastname, age, identification, driverslicense, email, carId, pickupDate, dropoffDate)
        {
        }

        public override string ToString()
        {
            return $"ID: {Id}, Firstname: {Firstname}, Lastname: {Lastname}, Age: {Age}, Identification: {Identification}, Driverslicense: {Driverslicense}, Email: {Email}, CarId: {CarId}, Pickup: {PickupDate}, Dropoff: {DropoffDate}";
        }
    }
}
