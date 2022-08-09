// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите целое число от 1 до 7 (включительно): ");
int number =  Convert.ToInt32(Console.ReadLine());

if (1 <= number && number <= 5) Console.WriteLine("Это рабочий день");
else if ( 6 <= number && number <= 7 ) Console.WriteLine("Это выходной");
else Console.WriteLine("Введеное число меньше или больше проверяемого интервала.");
