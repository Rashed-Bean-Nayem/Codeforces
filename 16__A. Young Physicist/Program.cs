using System;

namespace _16__A._Young_Physicist
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int size = int.Parse(Console.ReadLine());
                Console.WriteLine();

                int[,] input = new int[size,3];


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    input[i,j]= int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }



            int result = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result += input[i,j];
                }
            }



            if (result==0)
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
