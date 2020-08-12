using System;

namespace _24___A._Elephant
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            
            int count = 0;
        

            if (n<=5)
            {
                Console.WriteLine(1);
            }
            else if(n%5==0)
            {
                count = n / 5;
             

                Console.WriteLine(count);
            }
            else
            {
                count = n / 5;
                Console.WriteLine(count+1);
            }





        }
    }
}

