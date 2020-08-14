using System;

namespace _32__A._George_and_Accommodation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;


            for (int i = 0; i < n; i++)
            {



                string s = Console.ReadLine();
                
                string[] values = s.Split(' ');


                int p = int.Parse(values[0]);
                int q = int.Parse(values[1]);

                if (q - p >= 2)
                {
                    counter++;
                }


            }

            Console.WriteLine(counter);



            //string s = Console.ReadLine();
            //string[] values = s.Split(' ');
            //int x = int.Parse(values[0]);
            //int y = int.Parse(values[1]);
            //int z = int.Parse(values[2]);







        }
    }
}
