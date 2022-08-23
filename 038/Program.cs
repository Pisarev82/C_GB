// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int sizeArray = InputInt("Введите колличество элементов в массиве (целое положитльное число > 1): ");
int maxVal = InputInt("Введите максимальное число в массиве (целое положитльное число > 1): ");
int digitsAfterDot = InputInt("Введите колличество знаков после запятой (целое положительное число > 1): ");

if (sizeArray < 1 || maxVal < 1 || digitsAfterDot < 1)
{
    Console.WriteLine("Ошибки некорректного ввода будут обрабатываться в следующих версиях программы. Но это не точно.");
}
else Run();

void Run()
{
    double[] array = CreateArrayRndDouble(sizeArray, 0, maxVal, digitsAfterDot);
    Console.WriteLine("Получился следующий массив");
    PrintArray(array);
    double[] resultForAnsver = ArrayDifferenceMaxMin(array);
    Console.WriteLine($"В этом массиве максимальный элемент: {resultForAnsver[0]}, минимальный элемент: {resultForAnsver[1]}, а их разница: {resultForAnsver[2]}");
}

double [] CreateArrayRndDouble(int size, int min, int max, int digitsAfterDotInner)  
{
    
    double[] array = new double[size];
    Random rnd = new Random();
    double numberForArray = 0;
    for (int i = 0; i < size; i++) 
    {
        int divider = Convert.ToInt32(Math.Pow(10, digitsAfterDotInner));
        numberForArray = Convert.ToDouble(rnd.Next(min, max*divider))/ divider;
        array[i] = numberForArray;
    }
    return array;
} 

void PrintArray(double[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

// Имеются исключения представления некоторых чисел double в двоичной мантиссе, 
// поэтому используем округление. Для более точного вычисления результата желательно привести все значения
// массива в целое число и производить вычесления, но тогда теряется часть сути задачи.
double[] ArrayDifferenceMaxMin (double [] arrayForActions) 
{
    double[] result = new double[3];
    double min = arrayForActions[0];
    double max = arrayForActions[0];
    for (int i = 0; i < arrayForActions.Length; i++)
    {
        if (min > arrayForActions[i]) min = arrayForActions[i];
        if (max < arrayForActions[i]) max = arrayForActions[i];
    }
    double difference = Math.Round(max - min, digitsAfterDot, MidpointRounding.AwayFromZero);
    result[0] = max; result[1] = min; result[2] = difference;
    return result;
}

int InputInt (string input)
{
    Console.Write(input);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
