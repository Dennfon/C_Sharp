//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое целое число => ");
string one = Console.ReadLine();
int number1 = Convert.ToInt32(one);
Console.Write("Введите второе целое число => ");
string two = Console.ReadLine();
int number2 = Convert.ToInt32(two);

if (number1 < number2)
{
    Console.Write($"Max {number2}  Min {number1}");
}
else if (number1 > number2)
{
    Console.Write($"Max {number1}  Min {number2}");
}
else if (number1 == number2)
{
    Console.Write($"{number1} и {number2} равны");
}
// избыточный код, т.к. при вводе числа строкой выскакивает ошибка в консоль. Оставляю, т.к изначально пытался обработать этот вариант
//else
//{
//    Console.Write($"{number1} или {number2} не явялется числом");
//}
