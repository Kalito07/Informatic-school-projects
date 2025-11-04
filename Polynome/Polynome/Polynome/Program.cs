using System;

namespace Polynome
{
    class Polynome
    {
        private double[] a;
        public int Degree
        {
            get
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    if (a[i] != 0)
                        return i;
                }
                return 0;
            }
        }
        public Polynome(int degree)
        {
            a = new double[degree + 1];
        }

        public Polynome(double[] coefizients)
        {
            a = new double[coefizients.Length];
            Array.Copy(coefizients, a, coefizients.Length);
        }

        public static Polynome operator + (Polynome p1, Polynome p2)
        {
            int biggerPolynome = Math.Max(p1.Degree, p2.Degree);
            double[] result = new double[biggerPolynome + 1];

            for (int i = 0; i <= p1.Degree; i++)
                result[i] += p1.a[i];

            for (int i = 0; i <= p2.Degree; i++)
                result[i] += p2.a[i];

            return new Polynome(result);
        }

        public static Polynome operator - (Polynome p1, Polynome p2)
        {
            int biggerPolynome = Math.Max(p1.Degree, p2.Degree);
            double[] result = new double[biggerPolynome + 1];

            for (int i = 0; i <= p1.Degree; i++)
                result[i] += p1.a[i];

            for (int i = 0; i <= p2.Degree; i++)
                result[i] -= p2.a[i];

            return new Polynome(result);
        }

        public static Polynome operator * (Polynome p1, Polynome p2)
        {
            int resultDegree = p1.Degree + p2.Degree;
            double[] result = new double[resultDegree + 1];

            for (int i = 0; i <= p1.Degree; i++)
            {
                for (int j = 0; j <= p2.Degree; j++)
                {
                    result[i + j] += p1.a[i] * p2.a[j];
                }
            }

            return new Polynome(result);
        }

        public override string ToString()
        {
            string output = "";

            for (int i = Degree; i >= 0; i--)
            {
                if (a[i] == 0) continue;

                if (a[i] > 0 && output != "")
                    output += " + ";

                if (a[i] < 0)
                    output += " - ";

                double absValue = Math.Abs(a[i]);

                if (absValue != 1 || i == 0)
                    output += absValue;

                if (i > 0)
                    output += "x";

                if (i > 1)
                    output += "^" + i;
            }

            return output == "" ? "0" : output;
        }
    }
}
