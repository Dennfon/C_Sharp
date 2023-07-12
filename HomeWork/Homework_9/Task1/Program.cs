/*
Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int sumOfElementsInInterval(int m, int n)
{
    if (m == n)
    {
        return 0;
    }
    m++;
    return m + sumOfElementsInInterval(m, n);
}

int m = ReadInt("Введите число M > ");
int n = ReadInt("Введите число N > ");
System.Console.WriteLine(sumOfElementsInInterval(m - 1, n));