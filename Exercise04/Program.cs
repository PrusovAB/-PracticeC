Console.Clear();
Console.WriteLine("Введите число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

if (numberOne <= 1)
{
	Console.WriteLine("Число нужно целое больше 1: ");
}
else
{
	for (int i = 1; i <= numberOne; i++)
	{
		if (i % 2 == 0)
		{
			Console.Write($" {i}");

		}
	}
}


