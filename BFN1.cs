using System;

// task: https://pl.spoj.com/problems/BFN1/

public class BFN1
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
          int num = int.Parse(Console.ReadLine());
          int counter = 0;
          while (true)
          {
            if (num == PalindromeNum(num))
            {
              Console.WriteLine(num + " " + counter);
              break;
            }
            num += PalindromeNum(num);
            counter++;
          }
        }
    }

  public static int PalindromeNum(int number)
  {      
      int originalNumber = number;
      int reversedNumber = 0;

      while (number > 0)
      {
          int remainder = number % 10;
          reversedNumber = reversedNumber * 10 + remainder;
          number /= 10;
      }

      return reversedNumber;
  }
}
