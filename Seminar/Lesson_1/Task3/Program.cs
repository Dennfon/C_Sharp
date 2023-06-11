Console.WriteLine("Напишите целое положительное число");
string imput = Console.ReadLine();
int number1 = Convert.ToInt32(imput);
int number2 = -number1;
while (number2 <= number1)
{
    Console.Write(" " + number2);
    number2++;
}
