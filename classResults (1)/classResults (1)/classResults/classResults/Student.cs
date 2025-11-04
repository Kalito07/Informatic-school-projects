using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classResults
{
    class Student
    {
       
            public string name;
            public string classes;
            private string id;
            private double dBel, dForeign, dMath, dPhysics, dChemi, dBio;
            private double average;


            public Student()
            {
                this.name = "Not entered!";
                this.classes = "Not entered";
                this.id = "not entered";
                this.dBel = 2;
                this.dForeign = 2;
                this.dMath = 2;
                this.dPhysics = 2;
                this.dChemi = 2;
                this.dBio = 2;
            }

            public Student(string name, string classes, string id, double dBel, double dForeign, double dMath, double dPhysics, double dChemi, double dBio)
            {
                this.name = name;
                this.classes = classes;
                this.Id = id;
                this.DBel = dBel;
                this.DForeign = dForeign;
                this.DMath = dMath;
                this.DPhysics = dPhysics;
                this.DChemi = dChemi;
                this.DBio = dBio;
            }

            public Student(Student r)
            {
                this.name = r.name;
                this.classes = r.classes;
                this.Id = r.id;
                this.DBel = r.dBel;
                this.DForeign = r.dForeign;
                this.DMath = r.dMath;
                this.DPhysics = r.dPhysics;
                this.DChemi = r.dChemi;
                this.DBio = r.dBio;
            }

            public string Id
            {
                set
                {
                    int nomer = int.Parse(value);

                    if (nomer > 0 && nomer <= 26)
                    {
                        this.id = value;
                    }
                    else
                    {
                        throw new ArgumentException("The id must be between 1 and 26");
                    }

                }

                get => this.id;
            }

            public double DBel
            {
                set
                {
                    if (value >= 2 && value <= 6)
                    {
                        this.dBel = value;
                    }
                    else
                    {
                        throw new ArgumentException("Error");
                    }
                }
                get { return this.dBel; }
            }

            public double DForeign
            {
                set
                {
                    if (value >= 2 && value <= 6)
                    {
                        this.dForeign = value;
                    }
                    else
                    {
                        throw new ArgumentException("Error");
                    }
                }
                get { return this.dForeign; }
            }

            public double DMath
            {
                set
                {
                    if (value >= 2 && value <= 6)
                    {
                        this.dMath = value;
                    }
                    else
                        throw new ArgumentException("Error");
                }
                get { return this.dMath; }
            }

            public double DPhysics
            {
                set
                {
                    if (value >= 2 && value <= 6)
                    {
                        this.dPhysics = value;
                    }
                    else
                        throw new ArgumentException("Error");
                }
                get { return this.dPhysics; }
            }

            public double DChemi
            {
                set
                {
                    if (value >= 2 && value <= 6)
                    {
                        this.dChemi = value;
                    }
                    else
                        throw new ArgumentException("Error");
                }
                get { return this.dChemi; }
            }

            public double DBio
            {
                set
                {
                    if (value >= 2 && value <= 6)
                    {
                        this.dBio = value;
                    }
                    else
                        throw new ArgumentException("Error");
                }
                get { return this.dBio; }
            }


            private double CalcAvg()
            {
                this.average = (this.DBel + this.DForeign + this.DMath + this.DPhysics + this.DChemi + this.DBio) / 6;
                return this.average;
            }
    }

}



