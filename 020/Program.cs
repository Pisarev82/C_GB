
// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// int a1 = 3, b1 = 6,
//     a2 = 2, b2 = 1;

double distans = 0;
double Distans(int x1, int y1, int x2, int y2)
{
    return distans = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}
distans = Distans(3, 6, 2, 1);
System.Console.WriteLine(Math.Round (distans, 2, MidpointRounding.ToZero));
double distans2 = Distans(7, -5, 1, -1);
System.Console.WriteLine(Math.Round (distans, 2, MidpointRounding.ToZero));
