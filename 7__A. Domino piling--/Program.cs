using System;

namespace _7__A._Domino_piling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;


            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((n * k) / 2);
        }
    }
}
