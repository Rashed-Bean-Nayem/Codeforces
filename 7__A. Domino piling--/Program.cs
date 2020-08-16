using System;

namespace _7__A._Domino_piling
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string input = Console.ReadLine();
            string[] values = input.Split(' ');


            int n = Convert.ToInt32(values[0]);
            int k = Convert.ToInt32(values[1]);

            Console.WriteLine((n * k) / 2);
        }
    }
}
