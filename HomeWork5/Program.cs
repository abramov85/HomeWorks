int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

double[] CreateRandomDoubleArray(int size, int min, int max)
{
    double[] newArray = new double[size];

    for(int i = 0; i < size; i++)
        newArray[i] = Convert.ToDouble(new Random().Next(min, max +1)) + Math.Round(new Random().NextDouble(), 2);
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");
    Console.WriteLine();
    
}

void ShowDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");
    Console.WriteLine();
    
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int CountPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0) count ++;
//     return count;
// }

// int[] threeDigitsArray =  CreateRandomArray(10, 100, 1000);
// ShowArray(threeDigitsArray);
// int countPositives = CountPositiveNumbers(threeDigitsArray);
// Console.WriteLine($"There are {countPositives} positive number in array");

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int SumOfEven(int[] justArray)
// {
//     int sum = 0;
//     for (int i = 1; i < justArray.Length; i += 2) sum += justArray[i];
//     return sum;
// }

// int[] newArray = CreateRandomArray(6, -100, 100);
// ShowArray(newArray);
// int sumEven = SumOfEven(newArray);
// Console.WriteLine("Sum of numbers on even position = " + sumEven);

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double MinMaxDiff(double[] dblArray)
// {
//     double min = dblArray[0];
//     double max = dblArray[0];
//     for (int i = 1; i < dblArray.Length; i++)
//     {
//         if (dblArray[i] < min) min = dblArray[i];
//         if (dblArray[i] > max) max = dblArray[i];
//     }
//     return max - min;
// }

// double[] myDblArray = CreateRandomDoubleArray(5, -100, 100);
// ShowDoubleArray(myDblArray);
// double diff = MinMaxDiff(myDblArray);
// Console.WriteLine("Difference between min and max numbers is " + diff);
