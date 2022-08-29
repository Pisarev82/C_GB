// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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
    System.Console.WriteLine();
    return result;
} 

int[,] CreateMatrixDelMinRowCol(int[,] matrix, int row, int col) 
{
    
    int[,] result = new int[matrix.GetLength(0) - 1 , matrix.GetLength(1) - 1 ];
    int iNew = -1;
    int jNew = -1;   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        if (row == i) continue ;
        if (iNew < result.GetLength(1)-1) iNew++;
        jNew = -1;
 //       System.Console.WriteLine($" из первого цикла inew = {iNew}");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (col == j) continue ;
            if (jNew < result.GetLength(1)-1) jNew++;
//            System.Console.WriteLine($" из второго цикла jnew = {jNew}");
            if (iNew<result.GetLength(0) && jNew<result.GetLength(1)) result[iNew,jNew] = matrix[i,j];
//            System.Console.WriteLine(result[iNew,jNew]);
        }
        
    }
    return result;
} 


int[,] array2D = CreateMatrixRndInt(5,4,0,9);
PrintMatrix(array2D);
int[] minIndex = FindIndexMinInMatrix(array2D);
Console.WriteLine($"{minIndex[0]}, {minIndex[1]}");
int[,] newArray2D = CreateMatrixDelMinRowCol(array2D, minIndex[0], minIndex[1]);
PrintMatrix(newArray2D);
