using System;

namespace _4__A._Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();



            int[,] arr = new int[size, 3];


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine();
            }




            int count = 0;
            int result = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    count = count + arr[i, j];

                }
                if (count >= 2)
                {
                    result = result + 1;

                    count = 0;
                }

            }



            Console.WriteLine(result);
            //int n = 0, i, sum = 0, count = 0;
            //// scanf("%d", &n);
            //n = Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[5];

            //do
            //{
            //    for (i = 0; i < 3; i++)
            //    {
            //        // scanf("%d", &a[i]);
            //        a[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    sum = 0;
            //    for (i = 0; i < 3; i++)
            //    {
            //        if (a[i] == 1) sum++;
            //    }
            //    if (sum >= 2) count++;

            //    n--;
            //} while (n > 0);
            ////printf("%d\n", count);

            //Console.WriteLine(count);
            ////  return 0;





        }
    }
}
