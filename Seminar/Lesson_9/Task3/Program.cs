/*
Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int func(int number, int degree)
{
    if (degree <= 0)
    {
        return 1;
    }
    return number * func(number, degree - 1);

}

int a = ReadInt("Введите число > ");
int b = ReadInt("Введите степень > ");

System.Console.WriteLine(func(a, b));