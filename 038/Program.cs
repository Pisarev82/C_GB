// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int size = InputInt("Введите колличество элементов в массивеж ");


double [] CreateArrayRndInt(int size, int min, int max, int digitsAfterDot)  
{
    
    double[] array = new double[size];
    Random rnd = new Random();
    double numberForArray = 0;
    for (int i = 0; i < size; i++) 
    {
        int divider = Convert.ToInt32(Math.Pow(10, digitsAfterDot));
        numberForArray = Convert.ToDouble(rnd.Next(min, max*divider))/ divider;
        // numberForArray = Math.Round(numberForArray, digits, MidpointRounding.AwayFromZero);
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

double [] array = CreateArrayRndInt(10, 0, 100, 1);
PrintArray(array);

double[] ArrayDifferenceMaxMin (double [] arrayForActions) 
{
    double[] result = new double[3];
    double min = arrayForActions[0];
    double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i]) min = array[i];
    if (max < array[i]) max = array[i];
}
double result = max - min;
result[0] = max; result[1] = max; result[2] = result;
}

System.Console.WriteLine($"{max} {min} {result}");


int InputInt (string input)
{
    Console.Write(input);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
