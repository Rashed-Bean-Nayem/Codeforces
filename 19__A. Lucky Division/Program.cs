using System;

namespace _19__A._Lucky_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
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

           
            if (result == hj.Length)
            {
                Console.WriteLine("YES");
            }
            else if (((n % 4) == 0) || ((n % 7) == 0) || ((n % 44) == 0) || ((n % 47) == 0) 
                || ((n % 74) == 0) || ((n %444) == 0) || ((n % 447) == 0) || ((n % 474) == 0)
                || ((n % 477) == 0) || ((n % 777) == 0) || ((n % 774) == 0) || ((n % 744) == 0) 
                || ((n % 77) == 0) || ((n % 747) == 0))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            // 4,7,44,47,74,,77,444,447,474,477,747,777,774,744
        }
    }
}
