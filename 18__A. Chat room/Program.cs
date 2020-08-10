using System;

namespace _18__A._Chat_room
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int count = 0;
            
            char[] ch = new char[] {'h','e','l','l','o'};

            int number = 0;
            int count_2 = 0;

           
            for (int i = 0; i < 5; i++)
            {
                  
                for (int j = number; j < input.Length; j++)
                {
                    if (ch[i] == input[j])
                    {
                        count++;
                        count_2 = 1;
                       
                        number = j + 1;
                        if (count==5)
                        {

                            Console.WriteLine("YES");
                            goto another;
                            break;
                        }
                        break;

                    }
                    
                }
                if (count_2==0)
                {
                    goto Come;
                }
                count_2 = 0;

            }


            Come:
            Console.WriteLine("NO");
            another:
            Console.WriteLine();



        }
    }
}
