/*Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]:f} ");
    }
    System.Console.WriteLine();
}

double[] ShowArithmeticMeanByColumns(int[,] array)
{
    double[] nextArray = new double[array.GetLength(0)];
    double sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double temp = sum / array.GetLength(0);
        nextArray[j] = temp;
        sum = 0;
    }
    return nextArray;
}

int rows = ReadInt("Введите количество строк >");
int columns = ReadInt("Введите количество столбцов >");
int[,] array = GenerateArray2D(rows, columns, 0, 10);
PrintArray2D(array);
System.Console.WriteLine("===================");
double[] temp = ShowArithmeticMeanByColumns(array);
PrintArray(temp);
System.Console.WriteLine("===================");
