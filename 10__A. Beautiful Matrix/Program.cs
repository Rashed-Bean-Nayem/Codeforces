using System;

namespace _10__A._Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];

            int count = 0;
            int i_ = 0;
            int j_ = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }



            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] == 1)
                    {
                        i_ = i;
                        j_ = j;
                    }
                }

            }
           // Console.WriteLine(i_ + " " + j_);



            if ((i_ < 2 && j_ <= 4)   || (i_ == 2 && j_ <= 2))
            {

                arr[2, 2] = 1;

                for (int i = i_; i < 5; i++)
                {
                    for (int j = j_ + 1; j < 5; j++)
                    {
                        if (arr[i, j] != 1)
                        {
                            count++;
                        }
                        else if (arr[i, j] == 1)
                        {
                            count++;
                            goto rtrt;

                        }
                    }
                    break;
                }


                for (int i = i_ + 1; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (arr[i, j] != 1)
                        {
                            count++;
                        }
                        else if (arr[i, j] == 1)
                        {
                            count++;
                            goto rtrt;

                        }
                    }

                }


            rtrt:
                Console.WriteLine(count);
            }

            else
            {
                for (int i = 2; i < 5; i++)
                {
                    for (int j = 3; j < 5; j++)
                    {
                        if (arr[i, j] != 1)
                        {
                            count++;
                        }
                        else if (arr[i, j] == 1)
                        {
                            count++;
                            goto rtrt2;

                        }
                    }
                    break;
                }

                for (int i = 3; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (arr[i, j] != 1)
                        {
                            count++;
                        }
                        else if (arr[i, j] == 1)
                        {
                            count++;
                            goto rtrt2;

                        }
                    }

                }

            rtrt2:
                Console.WriteLine(count);
            }

        

        }
    }
}
