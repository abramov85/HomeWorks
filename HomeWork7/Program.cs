int[,] Create2dRandomArray(int rows, int columns, int minValue, int maxValue)
{
    // Console.Write("Input a number of rows: ");
    // int rows = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Input a number of columns: ");
    // int columns = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Input a minValue: ");
    // int minValue = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Input a maxValue: ");
    // int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

void ShowDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");
    Console.WriteLine();
    
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] Create2dDoubleRandomArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows,columns];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) + Math.Round(new Random().NextDouble(), 1);
    return array;
}

void Show2dDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)   
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

double[,] myDoubleArray = Create2dDoubleRandomArray();

Show2dDoubleArray(myDoubleArray);
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет
/*
int[] GetElenent(int[,] array)
{
    Console.Write("Input a row number: ");
    int rowNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a column number: ");
    int columnNum = Convert.ToInt32(Console.ReadLine());
    
    int[] result = new int[2];
    if (rowNum > 0 && rowNum < array.GetLength(0) + 1 && columnNum > 0 && columnNum < array.GetLength(1) + 1 )
        result[0] = array[rowNum - 1, columnNum - 1];
    else result[1] = 1;
    return result;

}
int[,] myArray = Create2dRandomArray(4, 3, 0, 9);
Show2dArray(myArray);
int[] answer = GetElenent(myArray);
if (answer[1] == 1) Console.WriteLine("No matches for such row and column");
else Console.WriteLine(answer[0]);
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
double[] Average(int[,] array)
{
    double[] result = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
        for (int i = 0; i < array.GetLength(0); i++)
            result[j] += Convert.ToDouble(array[i,j]) / Convert.ToDouble(array.GetLength(0));
    return result;
}

int[,] newArray = Create2dRandomArray(4, 3, 0, 9);
Show2dArray(newArray);
Console.WriteLine();
double[] average = Average(newArray);
ShowDoubleArray(average);
*/