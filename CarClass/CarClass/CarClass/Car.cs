using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int EngineVolume { get; set; }
        public int YearProd { get; set; }

        public Car() { }

        public Car(string brand, string model, int engineVolume, int yearProd)
        {
            Brand = brand;
            Model = model;
            EngineVolume = engineVolume;
            YearProd = yearProd;
        }

        public Car(string brand, string model) : this(brand, model, 0, 0) { }

        public double CalculateAnnualTax()
        {
            double annualTax = 0.2 * EngineVolume;
            if (YearProd <= 2000)
            {
                annualTax += 70.00;
            }
            else if (YearProd <= 2010)
            {
                annualTax += 60.00;
            }
            else
            {
                annualTax += 50.00;
            }

            return annualTax;
        }

        public void Print()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Engine Volume: {EngineVolume} cc");
            Console.WriteLine($"Year of Production: {YearProd}");
            Console.WriteLine($"Annual Tax: {CalculateAnnualTax():F2} BGN");
        }
    }
}
