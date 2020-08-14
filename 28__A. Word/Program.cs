using System;

namespace _28__A._Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
             
            int Ucounter = 0;
            int Lcounter = 0;


            for (int i = 0; i < input.Length; i++)
            {

                if ((int)input[i]>=97 && (int)input[i]<=122)
                {
                    
                    Lcounter++;
                }
                else
                {
                    Ucounter++;
                }

            }


            if (Ucounter==Lcounter || Ucounter<Lcounter)
            {
                Console.WriteLine(input.ToLower());
            }

            else
            {
                Console.WriteLine(input.ToUpper());
            }

        }
    }
}
