//Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

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

int number = Prompt("Введите число");

int Faktorial(int number)
{
    int count = 1;
    for (int i = 1; i <= number; i++)
    {
        count *= i;
    }

    return count;
}

int sum = Faktorial(number);
System.Console.WriteLine(sum);