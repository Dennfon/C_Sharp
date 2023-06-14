//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

string InfoForUser(int number)
{
    string info = "";
    if (number > 0 & number < 8)
    {
        if (number > 5 && number < 8)
        {
            info = "Выходной день";
        }
        else
        {
            info = "Рабочий день";
        }
    }
    else
    {
        System.Console.WriteLine($"Вы ввели неправильную цифру дня недели - {number}. Необходимо ввести число от 1 до 7");
    }

    return info;
}

int num = ReadInt("Введите число > ");
string mess = InfoForUser(num);
System.Console.WriteLine(mess);