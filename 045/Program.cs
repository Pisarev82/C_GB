// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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

int[] arr = CreateArrayRndInp(5, 1, 9);


int[] CreateArrayCopiArr(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (i == (array.Length - 1)) newArray[i] = -1;
        else newArray[i] = array[i];
        
    }
    return newArray;
}

int[] newArr = CreateArrayCopiArr(arr);
PrintArray(arr);
PrintArray(newArr);