using System;

// task: https://pl.spoj.com/problems/PTCLTZ/

public class PTCLTZ
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int counter = 0;
            while (x != 1)
            {
                if (x % 2 == 0)
                {
                    x = x / 2;
                }
                else
                {
                    x = x * 3 + 1;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
