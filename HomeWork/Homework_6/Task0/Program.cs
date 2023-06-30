/*Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine()!;
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine("Извините, но вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int CountPlusNumber(int number)
{
    int[] array = new int[number];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1} число");

        if (array[i] > 0)
        {
            count++;
        }
    }

    return count;
}

void PrintInfo(int number)
{
    int result = CountPlusNumber(number);
    System.Console.WriteLine($"Вы ввели {result} цифры(у) больше НУЛЯ");
}

int number = Prompt("Введите количество цифр, которые вы планируете ввести");
PrintInfo(number);

