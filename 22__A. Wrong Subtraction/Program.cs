using System;
using System.Xml;

namespace _22__A._Wrong_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);

            

            for (int i = 0; i < b; i++)
            {
                if (a%10==0)
                {
                    a = a / 10;
                }
                else
                {
                    a = a - 1;
                }
            }
            Console.WriteLine(a);




            

        }
    }
}
