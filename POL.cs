using System;

// task: https://pl.spoj.com/problems/PTCLTZ/

public class POL
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            for (int j = 0; j < str.Length / 2; j++)
            {
                Console.Write(str[j]);
            }
            Console.WriteLine();
        }
    }
}
