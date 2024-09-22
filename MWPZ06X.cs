using System;

// task: https://pl.spoj.com/problems/MWPZ06X/

public class MWPZ06X 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
		for (int i = 0; i < n; i++)
		{
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine(num*num);
		}
    }
}
