/*
Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int functionAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return functionAckerman(m - 1, 1);
    }
    else
    {
        return functionAckerman(m - 1, functionAckerman(m, n - 1));
    }
}

int m = ReadInt("Введите число M > ");
int n = ReadInt("Введите число N > ");

System.Console.WriteLine(functionAckerman(m, n));