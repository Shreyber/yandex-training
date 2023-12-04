using System;
using System.Linq;
class Program
{
	static void Main(string[] args)
	{
		var n = Convert.ToInt32(Console.ReadLine());
		var scores = Console.ReadLine()?.Split(' ').Select(x => Convert.ToInt32(x)).ToArray()!;
		int sumLeft = 0;
		int sumRight = scores.Sum();

		// Представляем рейтинг в виде графика и считаем "площадь" значений по бокам
		for (int i = 0; i < n; i++)
		{
			var result = (scores[i]*i - sumLeft) + (sumRight - scores[i] - scores[i]*(n-i-1));
			sumLeft += scores[i];
			sumRight -= scores[i];
			Console.Write($"{result} ");
		}
	}
}
