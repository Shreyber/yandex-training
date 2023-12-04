using System;
using System.Linq;
class Program
{
	static void Main(string[] args)
	{
		var m = Convert.ToInt32(Console.ReadLine()!.Split(' ')[1]);
		var array = Console.ReadLine()!.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
		for (int i = 0; i < m; i++)
		{
			var read = Console.ReadLine()!.Split(' ');
			var leftIndex = Convert.ToInt32(read[0]);
			var rightIndex = Convert.ToInt32(read[1]);
			var newArray = array[leftIndex..(rightIndex + 1)].ToList();
			newArray.RemoveAll(x => x == newArray.Min());
			if (newArray.Any())
				Console.WriteLine(newArray.First());
			else
				Console.WriteLine("NOT FOUND");
		}
	}
}
