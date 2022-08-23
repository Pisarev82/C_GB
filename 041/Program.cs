// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int numberOfNumbers = InputInt("Введите какое колличество чисел будем проверять: ");

if (numberOfNumbers > 0) 
{
    int[] numbers = CreateAndFillArray(numberOfNumbers);
    PrintNumbersAndCountPositiv(numbers);

}


int InputInt (string input)
{
    Console.Write(input);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}



int[] CreateAndFillArray(int numberOfNumbersForMetod)
{
    int[] array = new int[numberOfNumbersForMetod];
    
    for (int i = 0; i < numberOfNumbersForMetod; i++)
    {
        array[i] = InputInt ("Введите число: ");
    }
    return array;
}

void PrintNumbersAndCountPositiv(int[] array)
{
    int count = 0;
    Console.Write("Вы ввели следующие числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        if(array[i] > 0) count ++;
    }
    Console.WriteLine();
    if (count == 1)  Console.WriteLine($"Вы ввели {count} число больше нуля");
    else if (count == 2 || count == 3 || count == 4)  Console.WriteLine($"Вы ввели {count} числа больше нуля");
    else Console.WriteLine($"Вы ввели {count} чисел больше нуля");
}

