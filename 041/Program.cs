/* Задача 34: Задайте массив 
заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


Console.Write("Чтобы узнать количество чётных чисел в массиве, нажмите клавишу Enter. ");
Console.ReadLine();
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();    
    for (int i = 0; i < size; i++)
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
        if (i < array.Length-1) Console.Write($"{array[i]}, " );
        else Console.Write(array[i]);                                       
    }
    Console.Write("]");
    
}
int[] ArrayEven(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) even++;    
    }
    Console.Write($" В массиве чётных чисел: {even}." );
    return array;
}   

Console.Write("");
int[] arr = CreateArray(8, 100, 999);
PrintArray(arr);
ArrayEven(arr);



