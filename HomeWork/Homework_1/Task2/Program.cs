//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите целое число => ");
string one = Console.ReadLine()!;
int number1 = Convert.ToInt32(one);

if (number1 % 2 == 0)
{
    Console.Write($"Число {number1} является четныйм");
}
else
{
    Console.Write($"Число {number1} является не четныйм");
}