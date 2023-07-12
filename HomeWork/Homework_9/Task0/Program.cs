/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void evenNaturalNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        return;
    }
    if (firstNumber % 2 == 0)
    {
        System.Console.Write(firstNumber + " ");
    }
    evenNaturalNumbers(firstNumber + 1, secondNumber);
}

int m = ReadInt("Введите число M > ");
int n = ReadInt("Введите число N > ");
evenNaturalNumbers(m, n);