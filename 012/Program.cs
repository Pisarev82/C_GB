// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.Write("Введите первое число: ");
int first =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int sec =  Convert.ToInt32(Console.ReadLine());

int ostatok = first % sec ;

// if (ostatok != 0) Console.WriteLine($"{first}, {sec} -> некратно, остаток {ostatok}");
// else Console.WriteLine($"{first}, {sec} -> кратно");

string res = ostatok != 0 ? $"{first}, {sec} -> некратно, остаток {ostatok}" 
:  $"{first}, {sec} -> кратно";

Console.WriteLine(res);