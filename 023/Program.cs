// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int cube = 1;
int count = 1;
if ( n > 1 )
{
    while (count <= n)
    {
        System.Console.WriteLine($"{count} | {cube}");
        count++;
        cube = Convert.ToInt32(Math.Pow(count, 3));
    }
}
else {
    while (count >= n)
    {
        System.Console.WriteLine($"{count} | {cube}");
        count--;
        cube = Convert.ToInt32(Math.Pow(count, 3));
    }
}