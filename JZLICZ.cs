using System;
using System.Collections.Generic;

// task: https://pl.spoj.com/problems/JZLICZ/

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
                if (!letters.ContainsKey(words[j]))
                {
                    letters.Add(words[j], 1);
                } 
                else
                {
                    int value = letters[words[j]];
                    // update value
                }
            }
        }
        foreach (KeyValuePair<char, int> item in letters)
        {
            Console.WriteLine($"Klucz: {item.Key}, Wartość: {item.Value}");
        }
    }
}
