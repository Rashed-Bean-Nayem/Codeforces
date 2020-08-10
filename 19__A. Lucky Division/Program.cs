using System;

namespace _19__A._Lucky_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int rt = int.Parse(Console.ReadLine());
            string hj = rt.ToString();
            //  Console.WriteLine(hj);

            int result = 0;

            char a = '4';
            char b = '7';

            for (int i = 0; i < hj.Length; i++)
            {
                if (hj[i] == a || hj[i] == b)
                {
                    result++;
                }

                //Console.WriteLine(hj[i]);

            }

         //   Console.WriteLine(hj[0]);

           

            if (result == hj.Length)
            {
                Console.WriteLine("YES");
            }
            else if (rt % 4 == 0 || rt % 7 == 0)
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
