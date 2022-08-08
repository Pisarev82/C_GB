// Напишите программу, которая:
// 1. выводит случайное число из отрезка [10, 99] и
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10,100); // 10, 99+1 (100 не входит в выдачу)
//Console.WriteLine($"Случайное число из диапазона 10-99 => {number}");

int firstDigit = number /10;
int secondtDigit = number %10;

// if (firstDigit == secondtDigit) Console.WriteLine($"цифры числа равны");
// else if (firstDigit > secondtDigit) Console.WriteLine($"Наибольшая цифра {number} => {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра {number} => {secondtDigit}");

//int result = firstDigit >= secondtDigit ? firstDigit : secondtDigit; // тернарный оператор


string result = firstDigit == secondtDigit ? "Цыфры равны"
: firstDigit > secondtDigit ? firstDigit.ToString() : secondtDigit.ToString();
Console.WriteLine($"Наибольшая цифра {number} => {result}");





