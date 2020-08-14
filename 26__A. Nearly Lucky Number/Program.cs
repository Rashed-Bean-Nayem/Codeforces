using System;

namespace _26__A._Nearly_Lucky_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string hj = n.ToString();


            int result = 0;
          

            char a = '4';
            char b = '7';

            for (int i = 0; i < hj.Length; i++)
            {
                if (hj[i] == a || hj[i] == b)
                {
                    result++;
                }
               
            }


            if (result==4 || result==74)
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
