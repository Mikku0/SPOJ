using System;

// task: https://pl.spoj.com/problems/SUMA/

public class SUMA
{
    static void Main(string[] args)
    {
        int sum = 0;
        string input;

        while ((input = Console.ReadLine()) != null)
        {
            int num = int.Parse(input);
            sum += num;
            Console.WriteLine(sum);
        }
    }
}
