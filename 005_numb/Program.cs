﻿// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

System.Console.Write("Введите целое положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0) {
    int b =  - a;
    while (b <= a) {
        Console.Write($"{b} ");
        b++;
    }
}
else Console.Write("Вы ввели отрицательное число");