using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
	static void Main(string[] args)
	{
		var seq = Console.ReadLine()!;
		var stack = new Stack<char>();

		foreach (char c in seq)
		{
			if ("{[(".Contains(c))
			{
				stack.Push(c);
			}
			else if ("}])".Contains(c) && stack.TryPop(out char bracket))
			{
				if (c == '}' && bracket == '{'
					|| c == ')' && bracket == '('
					|| c == ']' && bracket == '[')
					continue;
				else
				{
					Console.WriteLine("no");
					return;
				}
			}
			else
			{
				Console.WriteLine("no");
				return;
			}
		}
		
		if (stack.Any())
			Console.WriteLine("no");
		else
			Console.WriteLine("yes");
	}
}