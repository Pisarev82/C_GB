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
    int[,] array = new int[10,10];
    int count = 1;
    int i = 0;
    int j = 0;
    int forvardRowStop = array.GetLength(0); 
    int forvardColStop = array.GetLength(1);
    int reversRowStop = 0;
    int reversColStop = 0;
    bool forvard = true;
    bool gorisontal = true;

    while(count <= array.Length)
    {
        if (count == array.Length) break;
        if(gorisontal && forvard)
        {
            if (j < forvardColStop-1)
            {
                array[i, j] = count;
                count++;
                j++;
            } else
            {
                forvardColStop--;
                gorisontal = !gorisontal;
            }
        }
        if(!gorisontal && forvard)
        {
            if (i < forvardRowStop-1)
            {
                array[i, j] = count;
                count++;
                i++;
            } else
            {
                forvardRowStop--;
                gorisontal = !gorisontal;
                forvard = !forvard;
            }
        }
        if (gorisontal && !forvard)
        {
            if (j > reversColStop)
            {
                array[i, j] = count;
                count++;
                j--;
            }
            else
            {
                reversColStop++;
                gorisontal = !gorisontal;
            }
        }
        if (!gorisontal && !forvard)
        {
            if(i > reversRowStop+1)
            {
                array[i, j] = count;
                count++;
                i--;
            }
            else
             {
                reversRowStop++;
                gorisontal = !gorisontal;
                forvard = !forvard;
            }
        }
    }
    array[i, j] = count;
    return array;
}

int[,] arr = CreateAndFillArray2D();
PrintMatrix(arr);