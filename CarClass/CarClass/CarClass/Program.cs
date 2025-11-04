
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brand = Console.ReadLine();
            string model = Console.ReadLine();
            int engineVolume = int.Parse(Console.ReadLine());
            int yearProd = int.Parse(Console.ReadLine());

            Car myCar = new Car(brand, model, engineVolume, yearProd);

            myCar.Print();
        }
    }
}
