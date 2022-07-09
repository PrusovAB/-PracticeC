Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo)
{
	Console.WriteLine($"Максимальное число {numberOne}");
}
else if (numberOne < numberTwo)
{
	Console.WriteLine($"Максимальное число {numberTwo}");
}
else
{
	Console.WriteLine($"Числа  {numberOne} и {numberTwo} ровны");
}

