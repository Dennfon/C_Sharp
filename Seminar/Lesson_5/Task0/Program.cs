int[] GenerateArray(int len, int min, int max)
{
    int[] answer = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + "\t");
    }
    System.Console.WriteLine();
}

int SumPositive(int[] array)
{
    int sum = 0;
    foreach (var item in array)
    {
        if (item > 0)
        {

            sum += item;
        }
    }
    return sum;
}

int SumNegative(int[] array)
{
    int sum = 0;
    foreach (var item in array)
    {
        if (item < 0)
        {

            sum += item;
        }
    }
    return sum;
}


int SumPlus(int[] array, bool isPositive = true)
{
    int sign = -1;
    if (isPositive)
    {
        sign = 1;
    }
    int sum = 0;
    foreach (var item in array)
    {
        if (item * sign > 0)
        {

            sum += item;
        }
    }
    return sum;
}


int[] array = GenerateArray(12, -9, 9);
PrintArray(array);
//System.Console.WriteLine($"Сумма положительных элементов {SumPositive(array)}");
//System.Console.WriteLine($"Сумма отрицательных элементов {SumNegative(array)}");
System.Console.WriteLine($"Сумма отрицательных {SumPlus(array, false)}  и положительных элементов {SumPlus(array)}");
