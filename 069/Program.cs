// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 

Console.WriteLine("Введите целое положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно целое положительное число: ");
int b = Convert.ToInt32(Console.ReadLine());

int DegreeNumber (int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * DegreeNumber(num1, num2 - 1);
}

Console.WriteLine($"Число {a} в степени {b} равняется {DegreeNumber(a,b)}");