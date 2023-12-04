using System;

class Program
{
	static void Main(string[] args)
	{
		int k = Convert.ToInt32(Console.ReadLine());
		int n = Convert.ToInt32(Console.ReadLine());

        ulong sum = 0;
		int emptySpace = 0;
		int[] people = new int[n];
		

		for (int i = 0; i < n; i++)
		{
			people[i] = Convert.ToInt32(Console.ReadLine());
		}

		// Забираем людей начиная с самого высокого этажа
		for (int i = n-1; i >= 0; i--)
		{
			// Пихаем в лифт всех кто влезет
			people[i] -= emptySpace;
			if (people[i] <= 0)
				emptySpace = -1 * people[i];

			// Пропускаем этаж, если на нем нет людей
			if (people[i] == 0) continue;

			// Минимальное количество подъемов * номер этажа * 2
			sum += ((ulong)people[i] + (ulong)k - 1) / (ulong)k * ((ulong)i+1) * 2;

			// Считаем сколько свободного места осталось в лифте после последнего захода на i-ый этаж
			if (people[i] % k != 0)
				emptySpace = k - people[i] % k;
			else
				emptySpace = 0;

		}

		Console.WriteLine(sum);
	}
}
