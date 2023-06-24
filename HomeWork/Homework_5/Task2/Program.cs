//Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GenerateArray(int len)
{
    double[] answer = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.NextDouble() * 100;
    }
    return answer;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string result = string.Format("{0:f2}", array[i]);
        System.Console.Write(result + "\t");
    }
    System.Console.WriteLine();
}

double FindDifferenceBetweenMaxAndMinElementOfArray(double[] array)
{
    double min = array[0];
    double max = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    System.Console.WriteLine("Min " + min);
    System.Console.WriteLine("Max " + max);
    return max - min;
}


double[] array = GenerateArray(10);
PrintArray(array);
double temp = FindDifferenceBetweenMaxAndMinElementOfArray(array);
string result = string.Format("{0:f2}", temp);
System.Console.WriteLine(result);