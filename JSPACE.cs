using System;
using System.Text;

// task: https://pl.spoj.com/problems/JSPACE/
public class JSPACE
{
	public static void Main(string[] args)
	{
		string str;
		while ((str = Console.ReadLine()) != null)
		{
			StringBuilder sb = new StringBuilder();
			bool capitalizeNext = false;
			
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == ' ')
				{
					capitalizeNext = true;
				}
				else
				{
					if (capitalizeNext)
					{
						sb.Append(Char.ToUpper(str[i]));
						capitalizeNext = false;
					}
					else
					{
						sb.Append(str[i]);
					}
				}
			}
			Console.WriteLine(sb.ToString());
		}
	}
}
