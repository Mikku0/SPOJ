using System;

// task: https://pl.spoj.com/problems/PA05_POT/

class PA05_POT
{
    static int FactorialLastDigit(int num1, int num2)
    {
        int exponentMod4 = num2 % 4;
        if (exponentMod4 == 0)
            exponentMod4 = 4;

        return (int)Math.Pow(num1 % 10, exponentMod4) % 10;

    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 10)
        {
            for (int i = 0; i < n; i++)
            {
                string[] nums = Console.ReadLine().Split();
                int num1 = int.Parse(nums[0]);
                int num2 = int.Parse(nums[1]);
                Console.WriteLine(FactorialLastDigit(num1, num2));
            }
        }
    }
}
