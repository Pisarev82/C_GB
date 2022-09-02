// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Create3DArrayRndInt(int abscissa, int ordinate, int applicator) 
{
    
    int[,,] array3D = new int[abscissa, ordinate , applicator];
    int count = 10;

    for (int i = 0; i < array3D.GetLength(0); i++) 
    {
        
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i,j,k] = count;
                count++;
            }
        }
    }
    return array3D;
} 

void PrintMatrix(int[,,] array3D) 
{
    for (int i = 0; i <  array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++) 
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.WriteLine($"{array3D[i, j, k]} ({i},{j},{k}) ");
            }
        }
    }
}

int[,,] arr = Create3DArrayRndInt(2,2,2);
PrintMatrix(arr);