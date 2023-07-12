/*
Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void func(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        return;
    }
    System.Console.Write(firstNumber + " ");
    func(firstNumber + 1, secondNumber);

}

int m = ReadInt("Введите число M > ");
int n = ReadInt("Введите число N > ");
func(m, n);