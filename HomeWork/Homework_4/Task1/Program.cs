//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine("Извините, но вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int SumOfNumber(int number)
{
    int sum = 0;
    for (int i = 0; i < number; i++)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

int number = Prompt("Введите число");
int sum = SumOfNumber(number);

System.Console.WriteLine(sum);