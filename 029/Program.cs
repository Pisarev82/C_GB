// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
FillArray(array);
PrintArray(array);

// Следующий закоментированный код проверяет работоспособность методов 
// int[] array0 = {1, 2, 5, 7, 19, 6, 1, 33};
// int[] array2 = new int[5];
// FillArray(array2);
// PrintArray(array0);
// PrintArray(array2);


int[] FillArray(int[] arrayForFill)
{
    Random rd = new Random();
    for (int i = 0; i < arrayForFill.Length; i++)
        {
            arrayForFill[i] = rd.Next();
        }
        return arrayForFill;
    }

void PrintArray(int[] arrayForPrint)
  {
    int length = arrayForPrint.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (i == length-1) Console.Write($"{arrayForPrint[i]}");
        else Console.Write($"{arrayForPrint[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine();
}

