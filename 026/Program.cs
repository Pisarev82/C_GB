// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int HowManyDigits (int number)
{
    int number_of_digits = 0;
    int x = number;
    while ( x != 0)
    {
        x /=10;
        number_of_digits++;
    }
    return number_of_digits;
}
int numberMod = number;
if (number < 0) numberMod = -number;

Console.WriteLine($"Число {number} состоит из {HowManyDigits (numberMod)} цифр.");