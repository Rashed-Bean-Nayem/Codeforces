using System;
using System.Runtime.InteropServices;

namespace _34__A._Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            string[] values = input.Split(' ');
            int[] arr = new int[number];

            int[] finalAraay = new int[100];
            int counter = 0;

            for (int i = 0; i < number; i++)
            {
                arr[i]= int.Parse(values[i]);
            }


            for (int i = 1; i <=100; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == i)
                    {
                        finalAraay[counter] = j + 1;
                        if (counter == (arr.Length - 1))
                        {
                            goto comme;
                        }


                        counter++;
                    }

                }
               
               
            }

        comme:
            foreach (var item in finalAraay)
            {
                if (item==0)
                {
                    break;
                }
                Console.WriteLine(item);
            }



            







            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}



        }
    }
}
