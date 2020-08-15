using System;

namespace _38__A._Magnets
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());

            double[] newArray = new double[100000];

            //for (long i = 0; i < newArray.Length; i++)
            //{
            //    newArray[i] = long.Parse(Console.ReadLine());
                
            //}

            long kk = 0;

            while (kk<newArray.Length)
            {
                newArray[kk] = Convert.ToDouble(Console.ReadLine());
                kk++;
            }

            long counter = 1;
            long n = 1;
            long x = 0;
            go:
            for (long i =x; i < newArray.Length; i++)
            {
                for (long j = n; j < newArray.Length; j++)
                {
                    if (newArray[i]!=newArray[j])
                    {
                        counter++;
                        n = j + 1;
                        x = j;
                        goto go;
                    }

                }
            }


            Console.WriteLine(counter);
        }
    }
}
