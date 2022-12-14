// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3  0+0 0+1 0+2 0+3
// 1 2 3 4  1+0 1+1 1+2 1+3
// 2 3 4 5  2+0 2+1 2+2 2+3





int[,] CreateMatrix (int row, int col) 
{
    
    int[,] matrix = new int[row, col];
   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
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

int[,] arrey2D =  CreateMatrix(3, 4); 
PrintMatrix(arrey2D);