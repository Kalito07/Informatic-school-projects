using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
        public class Student
        {
            public string Clas { get; set; }
            public string Id { get; set; }
            public string Name { get; set; }
            public double DBEL { get; set; }
            public double DForeign { get; set; }
            public double DMath { get; set; }
            public double DPhys { get; set; }
            public double DChem { get; set; }
            public double DBio { get; set; }

            public double Average => (DBEL + DForeign + DMath + DPhys + DChem + DBio) / 6;

            public Student() { }

            public Student(string name, string clas, string id)
            {
                Name = name;
                Clas = clas;
                Id = id;
            }

            public Student(string name, string clas, string id, double dBEL, double dForeign, double dMath, double dPhys, double dChem, double dBio)
            {
                Name = name;
                Clas = clas;
                Id = id;
                DBEL = dBEL;
                DForeign = dForeign;
                DMath = dMath;
                DPhys = dPhys;
                DChem = dChem;
                DBio = dBio;
            }

            public void Print()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Class: {Clas}");
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Average Grade: {Average:F2}");
            }
        }
}
