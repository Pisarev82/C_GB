// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите целое число: ");
int A = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i;
    }
return sum;
}

if (A > 0 ) Console.WriteLine($"Сумма чисел от 1 до {A} -> {SumNumbers(A)}");
else Console.WriteLine("Введено число меньше 0. Программа завершена.");