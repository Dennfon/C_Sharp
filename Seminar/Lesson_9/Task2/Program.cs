/*
Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
453 -> 12
45 -> 9
*/

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int func(int number)
{
    if (number <= 0)
    {
        return 0;
    }
    return number % 10 + func(number / 10);

}

int a = ReadInt("Введите число > ");
System.Console.WriteLine(func(a));