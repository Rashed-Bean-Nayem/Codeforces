using System;
using System.Globalization;

namespace _33__A._Beautiful_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            
            int b=a+1;
            come:
            int counter = 0;
           
            string input = b.ToString();


            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j <input.Length; j++)
                {
                    if (input[i]==input[j])
                    {
                        counter++;
                    }

                }


            }

            if (counter>4)
            {
                b++;
                goto come;
            }
            else
            {
                Console.WriteLine(b);
            }



        }
    }
}
