/*Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
2 4 | 3 4 2
3 2 | 3 3 1
Результирующая матрица будет:
18 20 8
15 18 7*/

int ReadInt(string input)
{
  Console.Write(input);
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

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int rows = ReadInt("Введите число строк 1-й матрицы: ");
int columns = ReadInt("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int columns2 = ReadInt("Введите число столбцов 2-й матрицы: ");

int[,] firstMartrix = GenerateArray2D(rows, columns, 1, 10);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = GenerateArray2D(rows, columns2, 1, 10);
Console.WriteLine($"Вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[rows,columns2];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);