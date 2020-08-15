using System;

namespace _37__A._Vanya_and_Fence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = input.Split(' ');

            int n = int.Parse(values[0]);
            int h = int.Parse(values[1]);

            int[] newArray = new int[n];  

            string anotherInput = Console.ReadLine();
            string[] anotherValues = anotherInput.Split(' ');

            for (int i = 0; i < n; i++)
            {
                newArray[i] = int.Parse(anotherValues[i]);
            }


            //foreach (var item in newArray)
            //{
            //    Console.WriteLine(item);
            //}

            int counter = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i]<=h)
                {
                    counter++;
                }
                else if (newArray[i]>h)
                {
                    counter += 2;
                }
            }

            Console.WriteLine(counter);



        }
    }
}
