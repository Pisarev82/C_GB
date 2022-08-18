// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int a = InputInt("Введите целое число, которое будем возводить в степень: ");
int b = InputInt("Введите целое число больше 0, степень в которую будем возводить предыщее число: ");

if (b > 0) 
{
    //                                                 
    Console.WriteLine($"По формуле -a^b число {a} в степени {b} равно {ExponentiationMath(a, b)}");
    Console.WriteLine($"По формуле (-a)^b число {a} в степени {b} равно {ExponentiationEasy(a, b)}");
    }
else Console.WriteLine($"Степень {b} не является натуральной. Программа завершила работу.");



int InputInt (string input)
{
    Console.Write(input);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// В случае с выражением −a^b происходит две операции: операция взятия противоположного значения и возведение в степень.
// Возведение в степень является более приоритетной операцией, чем взятие противоположного значения.

int ExponentiationMath(int number, int power)
{
    int result = number;
    
    if (number < 0)
    {
        number = -number;
    }
    for (int i = 0; i < power-1; i++)
    {
        result *= number;
    }
    return result;
}

// Если имеетсе в виду формула (-a)^b то реализация в  методе.
int ExponentiationEasy(int number, int power)
{
    int result = number;
   
    for (int i = 0; i < power-1; i++)
    {
        result *= number;
    }

    return result;
}