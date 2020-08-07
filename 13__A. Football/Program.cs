using System;

namespace _13__A._Football
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int jk = input[0]-48;

            
            int count = 0;
            int Count_2 = 0;

            int result_2 = 0;
            int result = 0;
            

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] - 48 == 1)
                {
                    Count_2++;


                    if (Count_2==7)
                    {
                        result_2 = 50;
                    }
                }
                else
                {
                    Count_2 = 0;
                }
            }



            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] - 48 == 0)
                {
                    count++;


                    if (count==7)
                    {
                        result = 100;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            if (result==100 || result_2==50)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
















            //if (jk == 1)
            //{
            //    Console.WriteLine("Happy?n");
            //}
            //else
            //{
            //    Console.WriteLine("oh no");
            //}
        }
    }
}
