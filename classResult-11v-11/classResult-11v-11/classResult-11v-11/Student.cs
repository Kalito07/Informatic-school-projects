using System;

namespace classResult_11v_11
{
    internal class Student
    {
        private string clas;
        public string Clas
        {
            get => clas;
            set => clas = value;
        }

        private int id;
        public int Id
        {
            get => id;
            set => id = value;
        }

        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        private double bel, math, foreign, phys, chem, bio;

        public double BEL
        {
            get => bel;
            set => bel = ValidateGrade(value);
        }
        public double Math
        {
            get => math;
            set => math = ValidateGrade(value);
        }
        public double Foreign
        {
            get => foreign;
            set => foreign = ValidateGrade(value);
        }
        public double Phys
        {
            get => phys;
            set => phys = ValidateGrade(value);
        }
        public double Chem
        {
            get => chem;
            set => chem = ValidateGrade(value);
        }
        public double Bio
        {
            get => bio;
            set => bio = ValidateGrade(value);
        }

        private double ValidateGrade(double grade)
        {
            if (grade >= 2 && grade <= 6)
                return grade;
            else
                throw new Exception("Въведената оценка не е валидна! Тя трябва да е между 2 и 6.");
        }

        public Student()
        {
            Clas = "";
            Id = 0;
            Name = "";
            BEL = 2;
            Math = 2;
            Foreign = 2;
            Phys = 2;
            Chem = 2;
            Bio = 2;
        }

        public Student(string clas, int id, string name, double bel, double math, double foreign, double phys, double chem, double bio)
        {
            Clas = clas;
            Id = id;
            Name = name;
            BEL = bel;
            Math = math;
            Foreign = foreign;
            Phys = phys;
            Chem = chem;
            Bio = bio;
        }

        public double AverageGrade
        {
            get
            {
                return (BEL + Math + Foreign + Phys + Chem + Bio) / 6;
            }
        }

        public override string ToString()
        {
            return $"{Clas} {Id} {Name} BEL:{BEL} Math:{Math} Foreign:{Foreign} Phys:{Phys} Chem:{Chem} Bio:{Bio} Avg:{AverageGrade:F2}";
        }
    }
}
