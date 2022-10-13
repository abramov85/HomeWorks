// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int Power(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++) result *= a;
    return result;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a power of number: ");
int pow = Convert.ToInt32(Console.ReadLine());

int poweredNumber = Power(num, pow);
Console.WriteLine(poweredNumber);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int SumOfDigits(int num)
{
    num = Convert.ToInt32(Math.Sqrt(Math.Pow(Convert.ToDouble(num),2))); // convert negative number to positive
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int sumOfDigits = SumOfDigits(num);
Console.WriteLine(sumOfDigits);
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// m = 5 -> [1, 2, 5, 7, 19]
// m = 3 -> [6, 1, 33]
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");
    Console.WriteLine();
    
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum value for generating: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum value for generating: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/

// FillArrayByUser
// What will happen when user input size < 0
/*
int GetSize()
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    while(size <= 0)
    {
        Console.Write("Number of elements have to be grather than 0: ");
        size = Convert.ToInt32(Console.ReadLine());
    }
    return size;
}

int[] FillArrayByUser(int size)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");
    Console.WriteLine();
    
}

int sizeOfArray = GetSize();
int[] myArray = FillArrayByUser(sizeOfArray);
ShowArray(myArray);
*/