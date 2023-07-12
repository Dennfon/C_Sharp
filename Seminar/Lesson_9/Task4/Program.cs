/*
Задача 5: Определите, является ли число степенью двойки:
N = 16 -> "Является степень двойки"
N = 12 -> “Не является степенью двойки”
*/

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool degreeOfTwo(int arg)
{
    if (arg <= 2)
    {
        return true;
    }

    if (arg % 2 == 1)
    {
        return false;
    }
    return degreeOfTwo(arg / 2);

}

int a = ReadInt("Введите число > ");
System.Console.WriteLine(degreeOfTwo(a));