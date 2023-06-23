// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число => ");
string one = Console.ReadLine()!;
int number1 = Convert.ToInt32(one);

int count = 1;

while (count <= number1)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
}