// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// 1 задать матрицу
// 2 напечатать матрицу
// 2 удалить строку и столбец
// 3 Найти наименьший элемент 
// 

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

int[] FindIndexMinInMatrix(int[,] array) 
{
   int min = array[0,0];
   int[] result = new int[2];
   int rowIndex = 0;
   int colIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (array[i, j] < min)
           {
            min = array[i, j];
            rowIndex = i;
            colIndex = j;
           }
        }
    }
    result[0] = rowIndex;
    result[1] = colIndex;
    return result;
} 

int[,] CreateMatrixDelMinRowCol(int[,] matrix, int row, int col) 
{
    
    int[,] result = new int[matrix.GetLength(0) - 1 , matrix.GetLength(1) - 1 ];
    int iNew = -1;
    int jNew = -1;   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        iNew ++;
        jNew = -1;
        if (row == i) i++;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            jNew ++;
            if (col == j) j++;
            if (iNew<result.GetLength(0) && jNew<result.GetLength(1)) result[iNew,jNew] = matrix[i,j];
        }
        
    }
    return result;
} 

int[,] array2D = CreateMatrixRndInt(5,4,0,9);
PrintMatrix(array2D);
int[] minIndex = FindIndexMinInMatrix(array2D);
Console.WriteLine();
Console.WriteLine($"{minIndex[0]}, {minIndex[1]}");
Console.WriteLine();
int[,] newArray2D = CreateMatrixDelMinRowCol(array2D, minIndex[0], minIndex[1]);
PrintMatrix(newArray2D);

// int[,] newArray2Dex = 
// {
//     {00, 01, 02 },
//     {10, 11, 12 }
// };
// Console.WriteLine();
// PrintMatrix(newArray2Dex);
// Console.WriteLine();
// Console.WriteLine(newArray2Dex[1,1]);
