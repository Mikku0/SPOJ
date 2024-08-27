using System;

// task: https://pl.spoj.com/problems/PRZEDSZK/

public class PRZEDSZK
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
          string str = Console.ReadLine();
          string[] numbers = str.Split(' ');
          int num1 = int.Parse(numbers[0]);
          int num2 = int.Parse(numbers[1]);
          int tmp = num1;
          while(true)
          {
            if (tmp % num1 == 0 && tmp % num2 == 0)
            {
              Console.WriteLine(tmp);
              break;
            }
            tmp += num1;
          }
        }
    }
}
