using System;

namespace _8__A._Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int p = 0;

            for (int i = 0; i < n; i++)

            {
                string b = Console.ReadLine();

                if (b[0] == '-' || b[2] == '-')

                {
                    p = p - 1;
                }

                else if (b[0] == '+' || b[2] == '+')

                {
                    p = p + 1;
                }
            }
            Console.WriteLine(p);




        }
    }
}