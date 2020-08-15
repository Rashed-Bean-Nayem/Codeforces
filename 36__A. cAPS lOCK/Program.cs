using System;

namespace _36__A._cAPS_lOCK
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length==1 && (int)input[0] >= 97 && (int)input[0] <= 122)
            {
                Console.WriteLine(input.ToUpper());
            }

            else if (input.Length == 1 && (int)input[0] >= 65 && (int)input[0] <= 90)
            {
                Console.WriteLine(input.ToLower());
            }


            else
            {

                int counter = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if ((int)input[i] >= 65 && (int)input[i] <= 90)
                    {
                        counter++;

                    }

                }

                int counter2 = 0;

                if ((int)input[0] >= 97 && (int)input[0] <= 122)
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        if ((int)input[i] >= 65 && (int)input[i] <= 90)
                        {
                            counter2++;

                        }

                    }
                }

               if (counter2 == (input.Length - 1))
                {
                    char[] array = input.ToLower().ToCharArray();


                    int b = (int)array[0] - 32;

                    char gh = (char)b;
                    array[0] = gh;

                    Console.WriteLine(array);

                }
                else if (counter == input.Length)
                {
                    Console.WriteLine(input.ToLower());
                }
                else
                {
                
                    Console.WriteLine(input);
                }

            }
        }
    }

}

