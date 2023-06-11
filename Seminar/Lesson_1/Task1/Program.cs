//Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
//a = 5; b = 25 -> да 
//a = 2 b = 10 -> нет 
//a = 9; b = -3 -> нет 
//a = -3 b = 9 -> да


Console.Write("Введите первое число =>");
string one = Console.ReadLine();
int oneNumber = Convert.ToInt32(one);
Console.Write("Введите второе число =>");
string two = Console.ReadLine();
int twoNumber = Convert.ToInt32(two);

int squared = twoNumber / oneNumber;

if (oneNumber == squared)
{
    Console.Write("Второе число является квадратом первого числа");
}
else
{
    Console.Write("Второе число НЕ является квадратом первого числа");
}
