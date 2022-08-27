// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

void PrintArray(double[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

double[] CalcArithMean (int[,] matrixInMethod )
{
    double[] result = new double[matrixInMethod.GetLength(1)];
    for (int j = 0; j < matrixInMethod.GetLength(1); j++)
    {
        for (int i = 0; i < matrixInMethod.GetLength(0); i++)
        {
            result[j] += matrixInMethod[i,j];
        }
        result[j] = Math.Round(result[j]/matrixInMethod.GetLength(0), 1);
    }
    return result;
}


int[,] arr = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(arr);
Console.WriteLine();
PrintArray(CalcArithMean(arr));


