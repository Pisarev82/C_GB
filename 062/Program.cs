// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] CreateAndFillArray2D()
{
    int[,] array = new int[4,4];
    int count = 1;
    int forvardRow = array.GetLength(0); 
    int forvardCol = array.GetLength(1);

    while()
    
    return array;
}

int[,] arr = CreateAndFillArray2D();
PrintMatrix(arr);