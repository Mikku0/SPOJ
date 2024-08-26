using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// task: https://pl.spoj.com/problems/CALC/

public class CALC
{
    public static void Main()
    {
        string data;
        while ((data = Console.ReadLine()) != null)
        {
            char oper = data[0];
            string[] parts = data.Split(' ');
            int num1 = int.Parse(parts[1].ToString());
            int num2 = int.Parse(parts[2].ToString());
            switch (oper)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                case '%':
                    Console.WriteLine(num1 % num2);
                    break;
            }
        }
    }
}
