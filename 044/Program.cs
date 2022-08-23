// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

// fibonacci(n) = n-1 + n-2
// fibonacci(0) = 0 проверка if
// fibonacci(1) = 1 проверка if
if (n == 0) Console.WriteLine("0");
if (n == 1) Console.WriteLine("1");
Console.Write("0 1 ");
int fibonacci = 2;
int number1 = 0;
int number2 = 1;
for (int i = 2; i < n; i++)
{

    fibonacci = number1 + number2;
    number1 = number2;
    number2 = fibonacci;
    Console.Write($"{fibonacci} ");
}



