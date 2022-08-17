// Задача 30. Напишите программу,, которая 
// выводит массив из 8 элементов , заполненный
// нулями и единичами в случайном порядке.
// [1,2,1,1,0,1,0,0] 

int[] FillArray()
{
    int[] array = new int[8];
        for (int i = 0; i < 8; i++)
        {
            array[i] = new Random().Next(0, 2);
        }
        return array;
    }

int[] array = FillArray();

void PrintArray()
  {
    Console.Write("[");
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write("]");
}
PrintArray();
