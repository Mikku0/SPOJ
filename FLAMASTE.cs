using System;

// task: https://pl.spoj.com/problems/FLAMASTE/

public class FLAMASTE
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            int counter = 1;
            char previousChar = str[0];
            for (int j = 1; j < str.Length; j++)
            {
                if (str[j] == previousChar)
                {
                    counter++;
                }
                else
                {
                    if (counter > 2)
                    {
                        Console.Write(previousChar + counter.ToString());
                    }
                    else
                    {
                        for (int k = 0; k < counter; k++)
                        {
                            Console.Write(previousChar);
                        }
                    }
                    previousChar = str[j];
                    counter = 1;
                }
            }
            if (counter > 2)
                    {
                        Console.Write(previousChar + counter.ToString());
                    }
                    else
                    {
                        for (int k = 0; k < counter; k++)
                        {
                            Console.Write(previousChar);
                        }
                    }
            Console.WriteLine();

        }
    }
}
