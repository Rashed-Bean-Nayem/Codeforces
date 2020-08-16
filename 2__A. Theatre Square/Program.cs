using System;

namespace _2__A._Theatre_Square
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] values = input.Split(' ');

            long rec1 = Convert.ToInt64(values[0]);
            long rec2 = Convert.ToInt64(values[1]);
            long sqrGra = Convert.ToInt64(values[2]);


            long a = 0, b = 0;

            if (rec1 % sqrGra == 0)
            {
                a = (rec1 / sqrGra);
            }
            else if (rec1 % sqrGra != 0)
            {
                a = (rec1 / sqrGra) + 1;
            }

            if (rec2 % sqrGra == 0)
            {
                b = (rec2 / sqrGra);
            }
            else if (rec2 % sqrGra != 0)
            {
                b = (rec2 / sqrGra) + 1;

            }

            Console.WriteLine(a * b);


        }
    }
}
