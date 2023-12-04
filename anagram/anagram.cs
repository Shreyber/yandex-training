using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
	static void Main(string[] args)
	{
		var word1 = Console.ReadLine()!.ToCharArray();
		var word2 = Console.ReadLine()!.ToCharArray();

		var dict1 = new Dictionary<char, int>();
		var dict2 = new Dictionary<char, int>();

		foreach (char c in word1)
		{	
			if (dict1.ContainsKey(c))
				dict1[c]++;
			else
				dict1[c] = 1;
		}

		foreach (char c in word2)
		{	
			if (dict2.ContainsKey(c))
				dict2[c]++;
			else
				dict2[c] = 1;
		}
		
		if (dict1.Count == dict2.Count && !dict1.Except(dict2).Any())
			Console.WriteLine("YES");
		else
			Console.WriteLine("NO");
	}
}
