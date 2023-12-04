using System;
class Program
{
	static void Main(string[] args)
	{
		var numbers = Console.ReadLine()!.Split(' ');
		var a = Convert.ToInt32(numbers[0]);
		var b = Convert.ToInt32(numbers[1]);
		var c = Convert.ToInt32(numbers[2]);
		var d = Convert.ToInt32(numbers[3]);

		var m = a * d + b * c;
		var n = b * d;
		var nod = gcd(m, n);

		Console.WriteLine($"{m / nod} {n / nod}");

		// Алгоритм Евклида
		int gcd(int a, int b) 
		{
			while (a != 0 && b != 0)
			{
				if (a > b)
					a %= b;
				else
					b %= a;
			}
			return a + b;
		}
	}
}