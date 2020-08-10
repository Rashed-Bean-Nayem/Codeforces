using System;

namespace _10__A._Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];

            int count = 0;
            int i_ = 0;
            int j_ = 0;

            for (int i = 0; i < 5; i++)
            {

                string s = Console.ReadLine();
                string[] values = s.Split(' ');
                for (int j = 0; j < 5; j++)
                {
                   
                arr[i, j] = int.Parse(values[j]);


                    if (arr[i, j] == 1)
                    {
                        i_ = i;
                        j_ = j;
                    }

                }
                Console.WriteLine();
            }


            int ans1 = Math.Abs(2-i_);
            int ans2 = Math.Abs(2-j_);


            Console.WriteLine(ans1+ans2);
        

        }
    }
}
