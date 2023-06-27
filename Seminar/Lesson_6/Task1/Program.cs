//Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

void Triangl(int a, int b, int c)
{
   
    string message = "";
    if (a < c + b && b < a + c && c < a + b)
    {
        message = "Yes";
    }
      else
    {
        message = "NO";
    }

    System.Console.WriteLine(message);

}

Triangl(3, 5, 4);