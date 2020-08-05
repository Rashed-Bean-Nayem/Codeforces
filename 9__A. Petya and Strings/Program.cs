using System;

namespace _9__A._Petya_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine().ToLower();
            string str2 = Console.ReadLine().ToLower();

            int result = str1.CompareTo(str2);
          
            Console.WriteLine(result);
        }
    }
}
