using System;

namespace YouTubeTekrar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { YearOfProduction = 2017, Model = "A4", Brand = "Audi" };
            Customer customer = new Customer() { YearOfProduction = 1999, Model = "Şahin", Brand = "Tofaş", MaxSpeed = 110 };

        }
    }

    class Car
    {
        public Car()
        {

        }
        public Car(int yearOfProduction, string model, string brand)
        {
            yearOfProduction = YearOfProduction;
            model = Model;
            brand = Brand;
        }
        public int YearOfProduction { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
    }
    class Customer : Car
    {
        public int MaxSpeed { get; set; }
    }
}