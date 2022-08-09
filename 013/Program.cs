// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите целое число: ");
int number =  Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;
if (number < 100) Console.WriteLine("Третьей цифры нет");
else 
{
    int divider = 1;
    int x = number;
    while (x != 0)
    {
        x = x/10;
        divider *= 10;
    } 
    int third_digit = number/(divider/1000)%10;
    Console.WriteLine($"Третья цифра вашего числа {third_digit}");
 }

