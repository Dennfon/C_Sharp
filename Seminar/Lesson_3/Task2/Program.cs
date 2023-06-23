//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


int ReadInt(string message)
{
    System.Console.WriteLine($"{message}");

    int value = int.Parse(Console.ReadLine()!);
    return value;

}

double Length(int x, int y)
{
    double temp = x * x + y * y;
    return Math.Sqrt(temp);
}

int x1 = ReadInt("Введите координату Х первой точки > ");
int y1 = ReadInt("Введите координату Y второй точки > ");
int x2 = ReadInt("Введите координату Х первой точки > ");
int y2 = ReadInt("Введите координату Y второй точки > ");

double result = Length(x1 - x2, y1 - y2);
System.Console.WriteLine($"Расстояние между двумя точками равно:  {result}");


