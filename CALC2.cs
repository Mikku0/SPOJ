using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CALC2
{
    public static void Main()
    {
        string data;
        int[] record = new int[10];
        while ((data = Console.ReadLine()) != null)
        {
            char oper = data[0];
            string[] parts = data.Split(' ');
            int num1 = int.Parse(parts[1].ToString());
            int num2 = int.Parse(parts[2].ToString());
            switch (oper)
            {
                case 'z':
                    record[num1] = num2;
                    break;
                case '+':
                    Console.WriteLine(record[num1] + record[num2]);
                    break;
                case '-':
                    Console.WriteLine(record[num1] - record[num2]);
                    break;
                case '*':
                    Console.WriteLine(record[num1] * record[num2]);
                    break;
                case '/':
                    Console.WriteLine(record[num1] / record[num2]);
                    break;
                case '%':
                    Console.WriteLine(record[num1] % record[num2]);
                    break;
            }
        }

    }
}