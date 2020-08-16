using System;

namespace _6__A._String_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

        Come:
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'y')
                {
                    input  = input.Remove(input.IndexOf(input[i]), 1);
                    //input = jk;
                    goto Come;
                }
            }

                 
            for (int i = 0; i < input.Length; i=i+2)
            {
                 input = input.Insert(i, ".");
             
            }
            Console.WriteLine(input);
           
        }
    }
}
