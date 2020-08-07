using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace _12__A._Word_Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string s = Console.ReadLine(); 
            s = Regex.Replace(s, @"(^\w)|(\s\w)", m => m.Value.ToUpper());

            Console.WriteLine(s);
        }
    }
}
