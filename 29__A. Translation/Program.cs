using System;
using System.Globalization;

namespace _29__A._Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_1 = Console.ReadLine().ToLower();
            string input_2 = Console.ReadLine().ToLower();
          
            int counter = 0;

           
            if (input_1.Length==input_2.Length)
            {


                for (int i = 0, j = input_2.Length - 1; i < input_1.Length; i++, j--)
                {
                    if (input_1[i] != input_2[j])
                    {
                        counter++;
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
