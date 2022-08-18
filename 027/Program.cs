// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = InputInt("Введите целое число: ");
int sumDigits = 0;
if (number < 0) sumDigits = SumDigits (-number);
else sumDigits = SumDigits (number);

Console.WriteLine($"Сумма цифр числа {number} является {sumDigits}.");


int InputInt (string input)
{
    Console.Write(input);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumDigits (int number)
{
    int sumDigits = 0;
    int x = number;
    while ( x != 0)
    {
        System.Console.WriteLine(x % 10);
        sumDigits += x % 10;
        x /=10;
    }
    return sumDigits;
}
