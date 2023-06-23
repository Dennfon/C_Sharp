//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое целое число => ");
string one = Console.ReadLine()!;
int number1 = Convert.ToInt32(one);

Console.Write("Введите второе целое число => ");
string two = Console.ReadLine()!;
int number2 = Convert.ToInt32(two);

Console.Write("Введите третье целое число => ");
string three = Console.ReadLine()!;
int number3 = Convert.ToInt32(three);

if (number1 > number2 && number1 > number3)
{
    Console.Write($"Максимальным является первое число: {number1}");
}
else if (number2 > number1 && number2 > number3)
{
    Console.Write($"Максимальным является второе число: {number2}");
}
else if (number3 > number2 && number3 > number1)
{
    Console.Write($"Максимальным является третье число: {number3}");
}
else if (number1 == number2 && number1 > number3)
{
    Console.Write($"Максимальным и одинаковыми является первое и второе число: {number1} и {number2}");
}
else if (number2 == number3 && number2 > number1)
{
    Console.Write($"Максимальным и одинаковыми является второе и третье число: {number2} и {number3}");
}
else if (number3 == number1 && number3 > number2)
{
    Console.Write($"Максимальным и одинаковыми является первое и третье число: {number1} и {number3}");
}
