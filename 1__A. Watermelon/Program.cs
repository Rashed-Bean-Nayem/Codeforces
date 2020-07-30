using System;

namespace _1__A._Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int wight = int.Parse(Console.ReadLine());



            if (wight % 2 == 0 && wight > 2)
            {
                Console.WriteLine("YES");

            }



            else
            {
                Console.WriteLine("NO");

            }

        }
    }
}
