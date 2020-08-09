using System;

namespace _16__A._Young_Physicist
{
    class Program
    {
        static void Main(string[] args)
        {

            //   int size = int.Parse(Console.ReadLine());

            //int sum1 = 0,a;
            //int sum2 = 0,b;
            //int sum3 = 0,c;


            //for (int i = 0; i < size; i++)
            //{
            //     a = int.Parse(Console.ReadLine());
            //     b = int.Parse(Console.ReadLine());
            //     c = int.Parse(Console.ReadLine());

            //    sum1 += a;
            //    sum2 += b;
            //    sum3 += c;

            //}
            //if (sum1 == 0 && sum2 == 0 && sum3 == 0)
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");


           

                int n = Convert.ToInt32(Console.ReadLine());

                int xsum = 0, ysum = 0, zsum = 0;

                for (int j = 0; j < n; j++)

                {
                    string s = Console.ReadLine();
                    string[] values = s.Split(' ');
                    int x = int.Parse(values[0]);
                    int y = int.Parse(values[1]);
                    int z = int.Parse(values[2]);
                    xsum += x;
                    ysum += y;
                    zsum += z;
                }

                if (xsum == 0 && ysum == 0 && zsum == 0)

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

