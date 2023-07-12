/*
Задача 6: Проверка на простое число: 
N = 13 -> "Это простое число"
N = 12 -> “Это не простое число”
*/

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool primeNumber(int arg, int divider = 0)
{
    if (divider == 0)
    {
        divider = arg - 1;
    }
    if (divider == 1)
    {
        return true;
    }
    return arg % divider > 0 && primeNumber(arg, divider - 1);
}

int number = ReadInt("Введите число > ");
System.Console.WriteLine(primeNumber(number));