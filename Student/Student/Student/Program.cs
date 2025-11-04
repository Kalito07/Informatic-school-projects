using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string clas = Console.ReadLine();
            string id = Console.ReadLine();

            double dBEL = double.Parse(Console.ReadLine());
            double dBio = double.Parse(Console.ReadLine());
            double dMath = double.Parse(Console.ReadLine());
            double dChem = double.Parse(Console.ReadLine());
            double dPhys = double.Parse(Console.ReadLine());
            double dForeign = double.Parse(Console.ReadLine());

            Student student = new Student(name, clas, id, dBEL, dForeign, dMath, dPhys, dChem, dBio);
            student.Print();
        }
    }
}
