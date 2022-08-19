// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] array = CreateArrayRndInp(5, 0, 9);
Console.Write("Введите число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintArray(array);
Console.Write(NumberIsInArray(array, number));

string NumberIsInArray (int[] arrayForSerch, int number)
{
    for (int i = 0; i < arrayForSerch.Length; i++)
    {
        if (arrayForSerch[i] == number) 
        {
            return $"число {number} содержится в массиве";
        }
    }
    return $"число {number} не содержится в массиве";
}


int[] CreateArrayRndInp(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if( i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}