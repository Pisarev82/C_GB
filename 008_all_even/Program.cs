// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число: ");
int end = Convert.ToInt32(Console.ReadLine());
int begin = 1;
if (end == begin) Console.Write("N = 1, между 1 и 1 нет интервала для проверки");
if (end>begin) 
    {
    while (begin <= end)
        {
            if (begin%2 == 0) Console.Write($"{begin} ");
            begin++;
        }
    }
else {
    while (begin >= end)
        {
            if (begin%2 == 0) Console.Write($"{begin} ");
            begin--;
        }
    }
