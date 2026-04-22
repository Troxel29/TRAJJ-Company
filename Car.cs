using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARRENTALBUSINESS
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal PricePerDay { get; set; }
        public bool IsAvailable { get; set; }
        public string ImagePath { get; set; }

        public Car(int id, string model, int year, decimal pricePerDay, bool isAvailable, string imagePath)
        {
            Id = id;
            Model = model;
            Year = year;
            PricePerDay = pricePerDay;
            IsAvailable = isAvailable;
            ImagePath = imagePath;
        }

        public override string ToString()
        {
            return $"{Model} ({Year}) - ${PricePerDay}/day - {(IsAvailable ? "Available" : "Unavailable")}";
        }
    }
}