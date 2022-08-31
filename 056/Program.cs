// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int row, int col, int min, int max) 
{
    
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("]");
    }
        
}

int[] SumRowElements (int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)]; 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i] += matrix[i,j];
        }
    }
    return result;
}

int MinIndexInArray (int[] array)
{
    int minIndex = 0;
    int min = array[minIndex];
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i]) 
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 0, 2);
PrintMatrix(array2D);
Console.WriteLine();

int minIndexForPrint = MinIndexInArray(SumRowElements(array2D)) + 1;
Console.WriteLine($"Минимальная сумма элементов в {minIndexForPrint} строке.");