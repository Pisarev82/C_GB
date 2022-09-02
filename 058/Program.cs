// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Так много комментариев, потому что долго разбирался с матрицими [2,3][3,2] оказывается их решением будет матрица [2,2]

int[,] matrixFirst = 
{
    {2, 4 },
    {3, 2 }
};

int[,] matrixSecond = 
{
    {3, 4 },
    {3, 3 }
};

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

int[,] multiplicationMatrix (int[,] matrix1, int[,] matrix2)
{
    // Размер результирующей матрицы ревен [колличество строк первой, колличество столбщов второй]
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    // умножаются элементы строки первой матрицы на элементы столбщов второй матрицы
    for (int i = 0; i < matrix1.GetLength(0); i++) // перебираем строки первой матрицы 
    {
        for (int j = 0; j < matrix2.GetLength(1); j++) // перебираем столбцы второй матрицы 
        {
            for (int k = 0; k < matrix1.GetLength(1); k++) // перебираем столбцы первой и строки второй (они равны, условие проверенно)
            {
                // номер строки первой матрицы = индекс строки результа матрицы
                // номер столбца второй матрицы = индекс столбца результа матрицы
                resultMatrix[i,j] += matrix1[i,k]*matrix2[k,j];
            }          
        }
    }  
    return resultMatrix;
}


// Первую матрицу можно умножить на вторую только 
// если   столбцы(первой) == строки(второй)
 if (matrixFirst.GetLength(1) == matrixSecond.GetLength(0))
{
    PrintMatrix(multiplicationMatrix (matrixFirst, matrixSecond));
} else Console.WriteLine("Матрицу 1 и 2 перемножить нельзя");

