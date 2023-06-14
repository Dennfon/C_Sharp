//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool Validate3sign(int number)
{
    if (number >= 100)
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное");
    return false;
}

int num = ReadInt("Введите число > ");
int lastDigit = 0;
System.Console.Write($"Третья цифра числа {num} равна ");
if (Validate3sign(num))
{
    while (num > 1000)
    {
        num /= 10;
        if (num <= 999)
        {
            break;
        }
    }
    lastDigit = num % 10;
}

System.Console.WriteLine($"{lastDigit}");