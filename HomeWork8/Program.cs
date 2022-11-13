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
    Console.WriteLine();
}

// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// void SortRow(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int jStart = 0; jStart < array.GetLength(1); jStart++)
//         {
//             int max = array[i,jStart];
//             int jMax = jStart;
//             for (int j = jStart + 1; j < array.GetLength(1); j++)
//             {
//                 if(array[i,j] > max)
//                 {
//                     max = array[i,j];
//                     jMax = j;
//                 }
//             }
//             array[i,jMax] = array[i,jStart];
//             array[i,jStart] = max;   
//         }
//     }
// }

// int[,] myArray = Create2dRandomArray(3,4,1,9);
// Show2dArray(myArray);
// SortRow(myArray);
// Show2dArray(myArray);


// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int MinSum(int[,] array)
// {
//     int iMin = 0;
//     int minSum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//             sum += array[i,j];
//         if(i == 0 || sum < minSum)
//         {
//             minSum = sum;
//             iMin = i;
//         }
//     }
//     return iMin;
// }

// int[,] newArray = Create2dRandomArray(4,4,1,9);
// Show2dArray(newArray);
// int rowNum = MinSum(newArray) + 1;
// Console.WriteLine($"min sum in {rowNum} row");

// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
// {
//     int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//     if(matrixA.GetLength(1) != matrixB.GetLength(0))
//     {   
//         Console.WriteLine("matrices do not meet the conditions for multiplication");
//         return result;
//     }
//     for (int i = 0; i < matrixA.GetLength(0); i++)
//         for (int j = 0; j < matrixA.GetLength(1); j++)
//             for (int k = 0; k < matrixB.GetLength(1); k++)
//                 result[i,k] += matrixA[i,j] * matrixB[j,k];
//     return result;
// }

// int[,] matrix1 = Create2dRandomArray(4,3,1,9);
// int[,] matrix2 = Create2dRandomArray(3,2,1,9);
// Show2dArray(matrix1);
// Show2dArray(matrix2);
// int[,] multMatrix = MatrixMultiplication(matrix1, matrix2);
// Show2dArray(multMatrix);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// bool FindNumIn3dArray(int[,,] array, int numToFind)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int k = 0; k < array.GetLength(2); k++)
//                 if(array[i,j,k] == numToFind) return true;
//     return false;

// }

// int[,,] Create3dNonrepeatingArray(int rows, int columns, int dimensions, int minValue, int maxValue)
// {
//     // Console.Write("Input a number of rows: ");
//     // int rows = Convert.ToInt32(Console.ReadLine());
//     // Console.Write("Input a number of columns: ");
//     // int columns = Convert.ToInt32(Console.ReadLine());
//     // Console.Write("Input a number of dimensions: ");
//     // int dimensions = Convert.ToInt32(Console.ReadLine());
//     // Console.Write("Input a minValue: ");
//     // int minValue = Convert.ToInt32(Console.ReadLine());
//     // Console.Write("Input a maxValue: ");
//     // int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,,] array = new int[rows, columns, dimensions];
//     if(rows * columns * dimensions > maxValue - minValue +1)
//     {
//         Console.WriteLine("the array is too big");
//         return array;
//     }
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             for (int k = 0; k < dimensions; k++)
//             {
//                 int value = new Random().Next(minValue, maxValue + 1);
//                 if(FindNumIn3dArray(array, value))
//                 {
//                     k--;
//                     continue;
//                 }
//                 array[i,j,k] = value;
//             }
//     return array;
// }

// void Show3dArray(int[,,] array)
// {
//     for (int k = 0; k < array.GetLength(2); k++)
//     {
//         Console.WriteLine($"Dimension {k + 1}");
//         for(int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//                 Console.Write(array[i,j,k] + "  ");
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,,] my3dArray = Create3dNonrepeatingArray(4,5,4,10,99);
// Show3dArray(my3dArray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] Create2dSpiralArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     int current = 10; // начал с 10 для ровного вывода массива
//     int direction = 1;
//     int i = 0;
//     int j = 0;
//     int minI = 0;
//     int minJ = 0;
//     int maxI = array.GetLength(0) - 1;
//     int maxJ = array.GetLength(1) - 1;
//     for (int count = 0; count < rows * columns; count++)
//     {
//         array[i,j] = current;
//         current++;
//         if(direction == 1 && j == maxJ)
//         {
//             direction = 2;
//             minI++;
//         }
//         if(direction == 2 && i == maxI)
//         {
//             direction = 3;
//             maxJ--;
//         }
//         if(direction == 3 && j == minJ)
//         {
//             direction = 4;
//             maxI--;
//         }
//         if(direction == 4 && i == minI)
//         {
//             direction = 1;
//             minJ++;
//         }
//         if(direction == 1) j++;
//         if(direction == 2) i++;
//         if(direction == 3) j--;
//         if(direction == 4) i--;
//     }
//     return array;
// }

// int[,] spiralArray = Create2dSpiralArray(4,4);
// Show2dArray(spiralArray);
