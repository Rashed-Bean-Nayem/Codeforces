using System;

namespace _2__A._Theatre_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int rec1 = Convert.ToInt32(Console.ReadLine());
            int rec2 = Convert.ToInt32(Console.ReadLine());
            int sqrGra = Convert.ToInt32(Console.ReadLine());


            //uint rec1 = Convert.ToUInt32(Console.ReadLine());
            //uint rec2 = Convert.ToUInt32(Console.ReadLine());
            //uint sqrGra = Convert.ToUInt32(Console.ReadLine());
            int a = 0, b = 0;

            if (rec1 % sqrGra == 0)
            {
                a = (rec1 / sqrGra);
            }
            else if (rec1 % sqrGra != 0)
            {
                a = (rec1 / sqrGra) + 1;
            }

            if (rec2 % sqrGra == 0)
            {
                b = (rec2 / sqrGra);
            }
            else if (rec2 % sqrGra != 0)
            {
                b = (rec2 / sqrGra) + 1;

            }

            Console.WriteLine(a * b);

//# include<stdio.h>
//            main(){
//                long long int x, y, z, a, b;
//                scanf("%lld%lld%lld", &x, &y, &z);
//                if (x % z == 0)
//                {
//                    a = (x / z);
//                }
//                else if (x % z != 0)
//                {
//                    a = (x / z) + 1;
//                }
//                if (y % z == 0)
//                {
//                    b = (y / z);
//                }
//                else if (y % z != 0)
//                {
//                    b = (y / z) + 1;
//                }




//                printf("%lld\n", a * b);
//            }


        }
    }
}
