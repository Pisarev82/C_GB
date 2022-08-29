// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

void ChangeColRowMatrix (int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {    
        int temp = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                if (i < j)
                {
                    
                    temp = array[i,j];
                    array[i,j] = array[j,i];
                    array[j,i] = temp;
                    Console.WriteLine($"Я меняю местами значения в ячейках с индексом {i}{j} -> {j}{i} значение {array[j,i]}");
                }
            }
        }
    }
    else Console.WriteLine("Строки со столбцами поменять нельзя");
}

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2d);

ChangeColRowMatrix(array2d);
Console.WriteLine();
PrintMatrix(array2d);