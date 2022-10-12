// Math.Pow(a,b) - a в степени b
// Math.Sqrt(a) - корень из a
// Math.Round(a,b) - округление числа a до b знаков после запятой
// тип данных всегда double

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
int MirrorNum(int number)
{
    int result = 0;
    while (number > 0)
    {
        int lastDigit = number - number / 10 * 10;
        result = result * 10 + lastDigit;
        number = number / 10;
    }
    return result;
}
// int32 works with numbers up to 2147483647
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

void IsPalindrome(int number)
{
    Console.WriteLine(number);
    int mirrored = MirrorNum(number);
    Console.WriteLine(mirrored);
    if (number == mirrored) Console.WriteLine("Number is palindrome");
    else Console.WriteLine("Number is not palindrome");
}

IsPalindrome(num);
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double[] GetCoordinate(string pointName)
{
    double[] coordinate = new double[3];
    Console.Write($"Input x-coordinate of point {pointName}: ");
    coordinate[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Input y-coordinate of point {pointName}: ");
    coordinate[1] = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Input z-coordinate of point {pointName}: ");
    coordinate[2] = Convert.ToDouble(Console.ReadLine());
    return coordinate;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");
    Console.WriteLine();
    
}

double[] coordinateA = GetCoordinate("A");
double[] coordinateB = GetCoordinate("B");
ShowArray(coordinateA);
ShowArray(coordinateB);

double distance = Math.Sqrt(
    Math.Pow(coordinateA[0] - coordinateB[0],2) + 
    Math.Pow(coordinateA[1] - coordinateB[1],2) + 
    Math.Pow(coordinateA[2] - coordinateB[2],2));

Console.WriteLine($"Distance between point A and B is {Math.Round(distance,2)}");
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = i + 1;
    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");
    Console.WriteLine();
    
}

double[] CubeArray(int[] currentArray)
{
    double[] newArray = new double[currentArray.Length];
    for(int i = 0; i < currentArray.Length; i++)
        newArray[i] = Math.Pow(Convert.ToDouble(currentArray[i]),3);
    return newArray;
}

Console.Write("Input a number (N) to generate cubes from 1 to N: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(number);
double[] cubeArray = CubeArray(array);
ShowArray(cubeArray);
*/