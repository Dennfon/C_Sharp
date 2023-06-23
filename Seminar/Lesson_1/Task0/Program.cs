//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.Write("Введите число =>"); //Приглашение ко вводу
string imputedString = Console.ReadLine()!; // Считывание ввода пользователя
int oneNumber = Convert.ToInt32(imputedString); // Преобразования строки к целому числу
Console.WriteLine($"Вы ввели число {oneNumber}!"); // Вывод информациии о введенном числе
int squared = oneNumber * oneNumber; // Логика программы (вычесление квадрата)
Console.WriteLine($"Квадрат числа {oneNumber} равен {squared}!"); //Вывод информации о вычеслении (вывод результата)

