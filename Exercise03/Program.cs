Console.Clear();
Console.WriteLine("Введите число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

if (numberOne == 0)
{
	Console.WriteLine($"Самое четное число их всех чисел = {numberOne}");
}
else
{
	if (numberOne % 2 == 0)
	{
		Console.WriteLine($"Введеное число = {numberOne} четное");
	}
	else
	{
		Console.WriteLine($"Введеное число = {numberOne} не четное");
	}
}
