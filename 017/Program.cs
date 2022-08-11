// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Точка находиться в первой четверти");
// else if (x < 0 && y > 0) Console.WriteLine("Точка находиться во второй четверти");
// else if (x < 0 && y < 0) Console.WriteLine("Точка находиться в третькй четверти");
// else if (x > 0 && y < 0) Console.WriteLine("Точка находиться в четвертой четверти");
// else Console.WriteLine("Введены некоретные координаты");

string GetQuarter (int xf, int yf)
{
    if (xf > 0 && yf > 0) return "Точка находиться в первой четверти";
    if (xf < 0 && yf > 0) return "Точка находиться во второй четверти";
    if (xf < 0 && yf < 0) return "Точка находиться в третькй четверти";
    if (xf > 0 && yf < 0) return "Точка находиться в четвертой четверти";
    return "Введены некоретные координаты";
}

String result = GetQuarter(x, y);
Console.WriteLine(result);