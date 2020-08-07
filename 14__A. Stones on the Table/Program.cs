using System;

namespace _14__A._Stones_on_the_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());


            //char[] an = new char[size];

            //for (int i = 0; i < an.Length; i++)
            //{
            //    an[i]= Convert.ToChar(Console.ReadLine());
            //}

            string ch = Console.ReadLine();


        
            int Count_2 = 0;

            int result_2 = 0;
       


            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'R' || ch[i] == 'r')
                {
                    Count_2++;

                

                    if (Count_2 >= 2)
                    {
                        result_2++;
                    }
                }
                else
                {
                    Count_2 = 0;
                }

                if (i == ch.Length - 1)
                {
                    Count_2 = 0;
                }




            }
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'G' || ch[i] == 'g')
                {
                    Count_2++;


                    if (Count_2 >= 2)
                    {
                        result_2++;
                    }
                }
                else
                {
                    Count_2 = 0;
                }


                if (i == ch.Length - 1)
                {
                    Count_2 = 0;
                }
            }

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'B' || ch[i] == 'b')
                {
                    Count_2++;

                    

                    if (Count_2 >= 2)
                    {
                        result_2++;
                    }
                }
                else
                {
                    Count_2 = 0;
                }
                if (i == ch.Length - 1)
                {
                    Count_2 = 0;
                }
            }



            Console.WriteLine(result_2);



        }
    }
}