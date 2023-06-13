

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.Readline());
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
if (Validate3sign(num))
{
    int lastDigit = num % 10;
    System.Console.WriteLine($"Последняя цифра числа {num} равна {lastDigit}");
}