using System;
using System.Collections.Generic;

namespace FIFA_11v_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxNumber = 99;
            int teamsCount = int.Parse(Console.ReadLine());

            List<HashSet<int>> teams = new List<HashSet<int>>();
            HashSet<int> usedNum = new HashSet<int>();

            for (int i = 0; i < teamsCount; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                HashSet<int> teamNumbers = new HashSet<int>();
                int added = 0;

                for (int j = 0; j < parts.Length && added < 11; j++)
                {
                    int number;
                    bool success = int.TryParse(parts[j].Trim(), out number);

                    if (success && number >= 1 && number <= maxNumber && !teamNumbers.Contains(number))
                    {
                        teamNumbers.Add(number);
                        added++;
                    }
                }

                teams.Add(teamNumbers);
                foreach (int num in teamNumbers)
                {
                    usedNum.Add(num);
                }
            }

            Console.WriteLine("Номера по отбори:");
            for (int i = 0; i < teams.Count; i++)
            {
                List<int> sorted = new List<int>(teams[i]);
                sorted.Sort();
                Console.WriteLine("Отбор " + (i + 1) + ": " + string.Join(", ", sorted));
            }

            Console.WriteLine("Всички използвани номера от всички отбори:");
            List<int> allUsed = new List<int>(usedNum);
            allUsed.Sort();
            Console.WriteLine(string.Join(", ", allUsed));

            HashSet<int> allPossibleNumbers = new HashSet<int>();
            for (int i = 1; i <= maxNumber; i++)
            {
                allPossibleNumbers.Add(i);
            }

            foreach (int num in usedNum)
            {
                allPossibleNumbers.Remove(num);
            }

            List<int> notUsed = new List<int>(allPossibleNumbers);
            notUsed.Sort();
            Console.WriteLine("Номера, които не се използват от никой отбор:");
            Console.WriteLine(string.Join(", ", notUsed));
        }
    }
}
