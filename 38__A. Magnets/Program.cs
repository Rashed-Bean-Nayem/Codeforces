using System;

class program 
{
     static int countGroups(int n, int[] m)
    {

        int count = 1;

        for (int i = 1; i < n; i++)

             if (m[i] != m[i - 1]) 
            {
                count++;
            }
              

        return count;
    }


    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] m = new int[n];

        for (int i = 0; i < m.Length; i++)
        {
            m[i] = int.Parse(Console.ReadLine());

        }

        

        Console.WriteLine(countGroups(n, m));
    }
}