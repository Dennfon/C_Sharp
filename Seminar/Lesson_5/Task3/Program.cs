//Задача 3: Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. Найдите количество  двузначных элементов массива. 
//Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0

int[] GenerateArray(int len, int min, int max)		// Создает и наполняет массив
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

void PrintArrey(int[] Arrey)				// Показывает в терминале массив
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
    System.Console.WriteLine();
}

int count(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
        if (Array[i] > 9 && Array[i] < 100)
        {
            sum++;
        }
    return sum;
}

int[] numberlist = GenerateArray(10, 1, 200);
System.Console.WriteLine(count(numberlist));

