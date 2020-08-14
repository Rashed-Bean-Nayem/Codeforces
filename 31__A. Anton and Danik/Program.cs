using System;

namespace _31__A._Anton_and_Danik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();


            int counter = 0;
            int counter2 = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i]==65)
                {
                    counter++;
                }

                else if ((int)input[i] == 68)
                {
                    counter2++;
                }
            }

            if (counter>counter2)
            {
                Console.WriteLine("Anton");
            }
            else if (counter<counter2)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }




        }
    }
}
