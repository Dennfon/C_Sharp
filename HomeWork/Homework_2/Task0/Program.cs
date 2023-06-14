//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool Validate3sign(int number)
{
    if (number >= 100 & number < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное");
    return false;
}

int num = ReadInt("Введите число > ");
int lastDigit = 0;
System.Console.Write($"Вторая цифра числа {num} равна ");
if (Validate3sign(num))
{
    num /= 10;
    lastDigit = num % 10;
}

System.Console.WriteLine($"{lastDigit}");
