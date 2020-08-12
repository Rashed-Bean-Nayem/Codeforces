using System;

namespace _21__A._Bear_and_Big_Brother
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);
          
            int counter = 0;

            while (true)
            {
                a *= 3;
                b *= 2;
                counter++;

                if (a>b)
                {
                    break;
                }



            }

            Console.WriteLine(counter);
        }
    }
}
