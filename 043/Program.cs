﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x * (k1 - K2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)     y = k1 * ((b2 - b1) / (k1 - k2)) + b1

double  b1 = InputInt ("Введите b1: "), 
        k1 = InputInt ("Введите k1: "), 
        b2 = InputInt ("Введите b2: "), 
        k2 = InputInt ("Введите k2: ");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
System.Console.WriteLine($"Точка пересечения двух прямых: ({x};  {y})");


double InputInt (string input)
{
    Console.Write(input);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}


