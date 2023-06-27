/*Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

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

void Raschet(double b1, double k1, double b2, double k2)
{
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}

void DownloadInfo (){
    double b1 = 0,k1=0, b2=0, k2=0;
     for (int i = 0; i < 4; i++)
    {
        if(i == 0)
        {
            b1 = Prompt("Введите координаты для точки B1 >");
        } else if(i==1)
        {
            k1 = Prompt("Введите координаты для точки K1 >");
        } else if(i==2)
        {
            b2 = Prompt("Введите координаты для точки B2 >");
        } else if(i==3)
        {
            k2 = Prompt("Введите координаты для точки K2 >");
        }
    }

    Raschet(b1, k1, b2, k2);

}   

DownloadInfo();