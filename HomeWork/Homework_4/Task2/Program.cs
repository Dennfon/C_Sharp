//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//(*) В 3-й задаче Доп сложность. Ввод с консоли “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”

int Prompt(string message)
{
    System.Console.Write($"{message} ");
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

int[] GenerateArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] SetIntroductoryVariables()
{
    int len = Prompt("Введите количество элементов массива > ");
    int min = Prompt("Введите минимальный порог случайных значений > ");
    int max = Prompt("Введите максимальный порог случайных значений > ");
    return GenerateArray(len, min, max);
}

void PrintArrey(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
}

int[] number = SetIntroductoryVariables();
PrintArrey(number);