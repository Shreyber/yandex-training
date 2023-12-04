using System;
class Program
{
	static void Main(string[] args)
	{
		var a = Convert.ToInt32(Console.ReadLine());
		var b = Convert.ToInt32(Console.ReadLine());
		var n = Convert.ToInt32(Console.ReadLine());

		if (Math.Ceiling((decimal)b / n) < a)
			Console.WriteLine("Yes");
		else
			Console.WriteLine("No");
	}
}