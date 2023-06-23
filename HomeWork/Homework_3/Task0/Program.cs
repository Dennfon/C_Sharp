//Задача 1
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int ReadInt(string message)
{
    Console.Write($"{message} ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int GetLength(int num)
{
    int temp = 0;
    while (num > 0)
    {
        num /= 10;
        temp++;
    }
    return temp;
}

bool IsPalindrome(int num)
{

    int Lenght = GetLength(num);
    int[] array = new int[Lenght];
    for (int i = Lenght - 1; i >= 0; i--)
    {
        array[i] = num % 10;
        num /= 10;
    }
    for (int i = 0; i < Lenght / 2; i++)
    {
        if (array[i] != array[Lenght - i - 1])
        {
            return false;
        }
    }

    return true;

}



int number = ReadInt("Введите целое положительное число >");
System.Console.WriteLine(IsPalindrome(number));

