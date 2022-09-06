// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9 

int SumDigitals (int numeber)
{
    int sum = numeber%10;
    if (numeber == 0) return sum;
    return sum + SumDigitals(numeber/10);
}

Console.WriteLine(SumDigitals(45));