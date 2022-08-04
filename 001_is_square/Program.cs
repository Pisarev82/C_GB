// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


 Console.Write("Введите целое число: ");
int a = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите еще одно целое число: ");
int b = Convert.ToInt32(System.Console.ReadLine());

if(b*b == a) Console.WriteLine($"число {a} является квадратом числа {b}");
else Console.WriteLine($"число {a} НЕ является квадратом числа {b}");
