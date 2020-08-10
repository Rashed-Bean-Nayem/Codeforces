using System;
using System.Diagnostics.CodeAnalysis;

namespace _17__A._Soldier_and_Bananas
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            string[] values = s.Split(' ');
                         
            int cost =int.Parse(values[0]);
            int dollar = int.Parse(values[1]);
            int total = int.Parse(values[2]);


            int sum = 0;
            for (int i = 1; i <= total; i++)
            {
                sum += (i*cost);           
            }

            int result = sum - dollar;

            if (result >= 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }

            

        }
    }
}
