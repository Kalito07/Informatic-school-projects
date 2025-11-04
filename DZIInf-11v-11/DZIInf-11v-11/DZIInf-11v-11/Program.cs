using System;
using System.Collections.Generic;

namespace DZIInf_11v_11
{
    class Program
    {
        static public List<double> ReadPoints(int count)
        {
            List<double> valid = new List<double>();
            for (int i = 0; i < count; i++)
            {
                double p = double.Parse(Console.ReadLine());
                if (p > 0)
                {
                    valid.Add(p);
                }
            }
            return valid;
        }

        static public double MinDpoints(List<double> points)
        {
            List<double> unique = new List<double>();
            for (int i = 0; i < points.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < unique.Count; j++)
                {
                    if (points[i] == unique[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    unique.Add(points[i]);
                }
            }

            for (int i = 0; i < unique.Count - 1; i++)
            {
                for (int j = i + 1; j < unique.Count; j++)
                {
                    if (unique[i] > unique[j])
                    {
                        double t = unique[i];
                        unique[i] = unique[j];
                        unique[j] = t;
                    }
                }
            }

            double minDif = double.MaxValue;
            for (int i = 0; i < unique.Count - 1; i++)
            {
                double dif = Math.Abs(unique[i] - unique[i + 1]);
                if (dif < minDif)
                {
                    minDif = dif;
                }
            }
            return minDif;
        }

        static public int Laureates(List<double> points)
        {
            List<double> unique = new List<double>();
            for (int i = 0; i < points.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < unique.Count; j++)
                {
                    if (points[i] == unique[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    unique.Add(points[i]);
                }
            }

            for (int i = 0; i < unique.Count - 1; i++)
            {
                for (int j = i + 1; j < unique.Count; j++)
                {
                    if (unique[i] < unique[j])
                    {
                        double t = unique[i];
                        unique[i] = unique[j];
                        unique[j] = t;
                    }
                }
            }

            double thirdHigh = unique[2];

            int count = 0;
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i] >= thirdHigh)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<double> valid = ReadPoints(N);

            Console.WriteLine($"valid works - {valid.Count}");
            Console.WriteLine($"minimal difference - {MinDpoints(valid):f3}");
            Console.WriteLine($"laureates - {Laureates(valid)}");
        }
    }
}
