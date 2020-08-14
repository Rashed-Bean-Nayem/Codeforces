using System;
using System.Globalization;

namespace _35__A._Kefa_and_First_Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            string[] values = input.Split(' ');
            int[] arr = new int[number];

            
            int counter = 1;

            for (int i = 0; i < number; i++)
            {
                arr[i] = int.Parse(values[i]);
            }

            int[] newArray = new int[number];
            int k = 0;


            if (number==1)
            {
                Console.WriteLine(1);
            }
            else
            {

                for (int i = 0, j = 1; i < number - 1; i++, j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        counter++;

                        if (i == (number - 2))
                        {
                            newArray[k] = counter;
                        }

                    }


                    else
                    {
                        newArray[k] = counter;
                        counter = 1;
                        k++;

                    }

                }


                int max = newArray[0];
                for (int i = 1; i < newArray.Length; i++)
                {
                    if (newArray[i] > max)
                    {
                        max = newArray[i];
                    }

                }
                Console.WriteLine(max);

            }



        }
    }
}
