// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sqr = 1;
int count = 1;
while (count <= n)
    {
    System.Console.WriteLine($"{count} {sqr}");
    count++;
    sqr = count * count;
}
