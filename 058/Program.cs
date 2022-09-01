// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] CreateMatrixRndInt(int row, int col, int min, int max) 
// {
    
//     int[,] matrix = new int[row, col];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// } 

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

int[,] matrix1 = 
{
    {2, 4, 5 },
    {3, 2, 2 }
};

int[,] matrix2 = 
{
    {3, 4 },
    {3, 3 },
    {1, 4 }
};

int[] SelectionRow(int[,] matrix2, int row)
{
    int[] result = new int[matrix2.GetLength(0)];
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
            result[i] = matrix2[row,i];
    } 
    return result;
}
int[] SelectionCol(int[,] matrix1, int col)
{
    int[] result = new int[matrix1.GetLength(0)];
    for (int i = 0; i < matrix1.GetLength(1); i++)
    {
            result[i] = matrix1[i,col];
    } 
    return result;
}

int[,] productOfMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    int[] row = SelectionRow(matrix2, 0);
    int[] col = SelectionCol(matrix1, 0);
    for (int i = 0; i < matrix2.GetLength(1); i++)
    {
        row = SelectionRow(matrix2, i);
        for (int j = 0; j < matrix1.GetLength(0); j++)
        {
            col = SelectionCol(matrix1, j);
            for (int k = 0; k < row.Length; k++)
            {  
                result[i,j] += row[k]*col[k];
            }
        }
    } 
    return result;
}
// Если число столбцов первой матрицы равно числу строк второй матрицы их можно умножить.
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
int[,] multMatrix = productOfMatrices(matrix2,matrix1);
PrintMatrix(multMatrix);
Console.WriteLine($"{matrix1.GetLength(0)}, {matrix2.GetLength(1)}");
} else Console.WriteLine("Умножать введенне матрицы нельзя");