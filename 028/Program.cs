// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число от 1 до 19: ");
int num = Convert.ToInt32(Console.ReadLine());

int factorial (int num)
{
    int n = 1;
    for (int i = 1; i <= num; i++)
    {
        n = n* i;
    }
    return n;
}

if (num>0 && num<20)
{
    int n = factorial(num);
    Console.Write($"произведение чисел от 1 до {num}: {n}");
}
else Console.Write("Введено некоретное значение. Программа завершена");

