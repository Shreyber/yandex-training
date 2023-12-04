using System;
using System.Linq;
class Program
{
	static void Main(string[] args)
	{
		var t = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i < t; i++)
		{
			var read = Console.ReadLine()!.Split(' ');
			var n = Convert.ToInt64(read[0]);
			var a = Convert.ToInt64(read[1]);
			var b = Convert.ToInt64(read[2]);

			var groupsCount = n / a;
			if (n % a == 0 || n % a <= groupsCount * (b - a))
				Console.WriteLine("YES");
			else
				Console.WriteLine("NO");
		}
	}
}