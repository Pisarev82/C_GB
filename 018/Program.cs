// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

string GetQuarter (int number)
{
    if (number == 1) return "В первой четверти находятся Х > 0 до бесконечности и Y > 0 до бесконечности";
    if (number == 2) return "Во второй четверти находятся отрицательные Х и положительные Y";
    if (number == 3) return "В третьей четверти находятся отрицательные Х и отрицательные Y";
    if (number == 4) return "В четвертой четверти находятся положительные Х и отрицательные Y";
    return "Такой четверти не существует";
}

String result = GetQuarter(x);
Console.WriteLine(result);



// string GetQuarter (int number)
// {
//     if (number == 1) return int x > 0;
//     if (number == 2) return "Во второй четверти находятся отрицательные Х и положительные Y";
//     if (number == 3) return "В третьей четверти находятся отрицательные Х и отрицательные Y";
//     if (number == 4) return "В четвертой четверти находятся положительные Х и отрицательные Y";
//     return "Такой четверти не существует";
// }

// String result = GetQuarter(x);
// Console.WriteLine(result);
