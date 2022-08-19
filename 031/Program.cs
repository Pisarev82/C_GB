// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
int[] arr = CreateArrayRndInp(12, -9, 9);
PrintArray(arr);
int[] getSumPopNegElem =GetSumPopNegElem(arr);
Console.WriteLine($"сумма положительных чисел равна {getSumPopNegElem[1]}, сумма отрицательных равна {getSumPopNegElem[0]}.");



int[] CreateArrayRndInp(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if( i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] GetSumPopNegElem(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sumNeg += array[i];
        else sumPos += array[i];
    }

    return new int[] { sumNeg, sumPos };
}














// int InputInt (string input)
// {
//     Console.Write(input);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }