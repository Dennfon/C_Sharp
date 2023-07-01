/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
0, 0 -> 1*/

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D(int rows, int columns, int min, int max)
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(min, max + 1);
        }
    }
    return numbers;
}

void PrintArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[] ShowNumberByCoordinates(int[,] array, int numberRows, int numberColums)
{
    int[] result = new int[1] { -1 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == numberRows)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == numberColums)
                {
                    result[0] = array[i, j];
                }
            }
        }

    }
    return result;
}

int rows = ReadInt("Введите количество строк >");
int columns = ReadInt("Введите количество столбцов >");
int[,] array = GenerateArray2D(rows, columns, -10, 10);
PrintArray2D(array);

int[] output = ShowNumberByCoordinates(array, ReadInt("Введите номер строки => "), ReadInt("Введите номер колонки => "));
if (output[0] == -1) Console.WriteLine("Такого числа в массиве нет");
else
{
    Console.WriteLine($"{output[0]}");
}
