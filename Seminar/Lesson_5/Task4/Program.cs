// Задача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

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


int number = Prompt("Введите число");
int[] list = new int[number / 2 + number % 2];
int[] numberlist = GenerateArray(number, 1, 10);

list[list.Length - 1] = numberlist[list.Length - 1];
for (int i = 0; i < numberlist.Length / 2; i++)
{
    list[i] = numberlist[i] * numberlist[numberlist.Length - i - 1];
}


PrintArrey(numberlist);
PrintArrey(list);
