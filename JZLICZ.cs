using System;
using System.Collections.Generic;
using System.Linq;

// task: https://pl.spoj.com/problems/PP0604A/
public class JZLICZ
{
	public static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());
		Dictionary<char, int> letters = new Dictionary<char, int>();
		for (int i = 0; i < n; i++)
		{
			string words = Console.ReadLine();
			for (int j = 0; j < words.Length; j++)
			{
				if (words[j] == ' ')
				{
					continue;
				}
				else if (!letters.ContainsKey(words[j]))
				{
					letters.Add(words[j], 1);
				}
				else
				{
					letters[words[j]] = letters[words[j]] + 1;
				}
			}
		}

		var sortedList = letters.OrderBy(pair => char.IsLower(pair.Key) ? 0 : 1)
                              .ThenBy(pair => pair.Key)
                              .ToList();
		
		foreach (var pair in sortedList)
		{
			Console.WriteLine(pair.Key + " " + pair.Value);
		}
	}
}