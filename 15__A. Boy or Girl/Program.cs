using System;

namespace _15__A._Boy_or_Girl
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();


            char [] ch = input.ToCharArray();

    
            char[] now = new char[100];

            int amCount = 0;
          
            int i, j;
            int k= 0;
          

            for (i = 0; i < ch.Length; i++)
            {
                for (j = 0; j <ch.Length; j++)
                {
                   

                        if (ch[i] == now[j])
                    {

                        amCount++;
                        
                    }
                }


                if (amCount ==0)
                {
                    now[k] = ch[i];

                    k++;
                }
                amCount = 0;

            }



            if (k%2==0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }


            }
    }
}
