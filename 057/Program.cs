// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] CreatArrayFrom2D (int[,] array)
{
    int size = array.GetLength(0)*array.GetLength(1);
    int[] result = new int[size];
    int count = 0;
    for (int i = 0; i <  array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            result[count] = array[i,j];
            count++; 
        }
    }
    Array.Sort(result);
    return result;
}

void FrequencyDictionary (int[] arr)
{
    int value = 0;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != value && i == 0) 
        {
            value = arr[i];
            count++;
        }
        else if (arr[i] != value)
        {
            Console.WriteLine($" Элемент {value} встречается {count} раз.");
            value = arr[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($" Элемент {value} встречается {count} раз.");
}


int[,] array2D = CreateMatrixRndInt(2,4,0,3);
PrintMatrix(array2D);
FrequencyDictionary(CreatArrayFrom2D(array2D));

