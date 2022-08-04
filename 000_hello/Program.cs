//Напишите программу, которая на вход
//принимает число и выдаёт его квадрат (число
//умноженное на само себя).
//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int square = Convert.ToInt32(Math.Pow(number, 2));
Console.Write($"Квадрат числа {number} = {square}");
// System.Console.Write("square");
