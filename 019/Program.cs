// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Решение для пятизначного числа:
Console.Write("Введите пятизначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) Console.WriteLine("{0} -> Отрицательное число не может быть палиндромом", number);
else {
    int first = number/10000;
    int last = number%10;
    int second = number/1000%10;
    int prelast = number/10%10;

    if (first == last && second == prelast) Console.WriteLine("{0} -> является палиндромом", number);
    else Console.WriteLine("{0} -> не является палиндромом", number);
}





// Бонус решение для любого числа int32 через массив и арифмитически.
// При замене ВСЕХ переменных на int64(16) логика будет работать.
// Получен первычный опыт использования методов, массива, области видемости переменных.

// Решение арифмитически.
// Console.Write("Введите любое целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0) Console.WriteLine("{0} -> Отрицательное число не может быть палиндромом", number);
// else IsPalindrome(number);

// Решение через массив (без строк!)
// Console.Write("Введите любое целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
//  if (number < 0) Console.WriteLine("{0} -> Отрицательное число не может быть палиндромом", number);
//  else IsPalindromeArray (number);








// Следующие методы спользуется в арифмитическом нахождении и нахождении через массив.
int HowManyDigits (int number)
{
    int number_of_digits = 0;
    int x = number;
    while ( x != 0)
    {
        x /=10;
        number_of_digits++;
    }
    return number_of_digits;
}

// Следующие методы  используются в нахождении через массив
void IsPalindromeArray (int number2)
{
    int number_of_digits = HowManyDigits(number2);
    int[] array = FillDigitsArray(number2, number_of_digits);
    if (EqualsLastFirstArray (array)) Console.WriteLine("{0} является палиндромом", number);
    else Console.WriteLine("{0} не является палиндромом", number);
} 

int[] FillDigitsArray (int number1, int number_of_digits)
{
    int[] digits = new int[number_of_digits];
    for (int count = 0; count < number_of_digits; count++)
    {
        digits[count] = number1%10;
        number1 /=10;
    }
    return digits;
}

bool EqualsLastFirstArray (int[] array) 
{   
    int count = 0;
    int end = array.Length-1;
     while (count < end)
    {
        if (array[count] != array[end])
        {
            return false;
        }
        count++;
        end--;
    }
    return true;
}





// Следующие методы  используются в нахождении арифмитически
void IsPalindrome (int number)
{
    
    int number_of_digits = HowManyDigits(number);
    int modifiedMumber = number;
    while (number_of_digits != 0)
    {   
        if (EqualsLastFirst (modifiedMumber, number_of_digits))
        {
            modifiedMumber = ModifiedNumber(modifiedMumber, number_of_digits);
            number_of_digits -= 2;
            
            if (number_of_digits  < 1) 
            {
                Console.WriteLine("{0} является палиндромом", number); 
                break;
                }
        }
        else 
        {
            Console.WriteLine("{0} не является палиндромом", number);
            break;
        }

    }
}

bool EqualsLastFirst (int number, int number_of_digits) 
{
    int divider =  Divider(number_of_digits);
    return number/divider == number%10;
}

int ModifiedNumber (int num, int number_of_digits)
{
    int divider =  Divider(number_of_digits);
    return (num - num/divider * divider)/10;;
} 

int Divider (int number_of_digits) 
{
    return  Convert.ToInt32(Math.Pow(10, number_of_digits-1));
}