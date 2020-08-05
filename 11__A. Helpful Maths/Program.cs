using System;

namespace _11__A._Helpful_Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] arr = new int[input.Length];

            //int size = input.Length;




            //int df = Convert.ToInt32(input[0]);
            //Console.WriteLine(df-48);

            for (int i = 0,j=0; j < input.Length; i++,j=j+2)
            {
                arr[i] = input[j]-48;
            }

            Array.Sort(arr);
            for (int i = arr.Length/2; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

                if (i==arr.Length-1)
                {
                    break;
                }

                Console.Write("+");
            }

           


        }
    }
}
