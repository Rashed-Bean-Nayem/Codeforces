using System;

namespace _16__A._Young_Physicist
{
    class Program
    {
        static void Main(string[] args)
        {

           
           
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

