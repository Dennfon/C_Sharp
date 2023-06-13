//2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int what = new Random().Next(10, 99);

System.Console.WriteLine($"Число - {what}");

int n1 = what / 10;
int n2 = what % 10;

if (n1 > n2)
{
    System.Console.WriteLine($"Большее число - {n1}");
}
else
{
    System.Console.WriteLine($"Большее число - {n2}");
}

