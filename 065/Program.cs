// Андрей Булгаков: Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
//                  8, 7, 6, 5, 4

Console.WriteLine("Введите целое положительное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно целое положительное число");
int number2 = Convert.ToInt32(Console.ReadLine());

void PrintNaturalNumber(int num1, int num2)
{
    if ( num1 > num2 ) 
    {
        if(num1 == num2 -1 ) return ;
        Console.Write($"{num1} ");
        PrintNaturalNumber(num1-1, num2);
        
    } 
    else if (num2 > num1 )
    {
        if(num2 == num1 - 1) return ;
        PrintNaturalNumber(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else if (num2 == num1 )
    {
        Console.Write($"{num2} ");
    }

}

 PrintNaturalNumber(number1, number2);