//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


int ReadInt(string message)
{
    System.Console.WriteLine($"{message}");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

double Length(int x, int y, int z)
{
    double temp = x * x + y * y + z * z;
    return Math.Sqrt(temp);
}

int x1 = ReadInt("Введите координату X первой точки > ");
int y1 = ReadInt("Введите координату Y второй точки > ");
int z1 = ReadInt("Введите координату Z первой точки > ");
int x2 = ReadInt("Введите координату X первой точки > ");
int y2 = ReadInt("Введите координату Y второй точки > ");
int z2 = ReadInt("Введите координату Z второй точки > ");

double result = Length(x2 - x1, y2 - y1, z2 - z1);
System.Console.WriteLine($"Расстояние между двумя точками равно:  {result}");



