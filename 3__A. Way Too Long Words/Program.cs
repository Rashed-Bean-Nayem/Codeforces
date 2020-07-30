using System;

namespace _3__A._Way_Too_Long_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());
            string[] word = new string[total];

            for (int i = 0; i < word.Length; i++)
            {
                word[i] = Console.ReadLine().ToLower();
            }

            Console.WriteLine();



            for (int i = 0; i < word.Length; i++)
            {



                if (word[i].Length > 10)
                {
                    Console.Write(word[i][0]);

                    Console.Write(+word[i].Length - 2);
                    Console.Write(word[i][word[i].Length - 1]);
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine(word[i]);
                }
            }

            //Console.Write(word[1][0]);

            //Console.Write(+word[1].Length - 2);
            //Console.Write(word[1][word[1].Length - 1]);


        }
    }
}
