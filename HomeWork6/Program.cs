// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int CountPositives(int M)
// {
//     int count = 0;
//     for (int i = 0; i < M; i++)
//     {
//         Console.Write($"Input {i + 1} number: ");
//         if (Convert.ToInt32(Console.ReadLine()) > 0) count ++;
//     }
//     return count;
// }

// Console.Write("Input quantity of numbers: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int countPositives = CountPositives(num);
// Console.WriteLine(countPositives);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double[] Intersection(double k1, double k2, double b1, double b2)
// {
//     double[] array = new double[2];
//     array[0] = (b2 - b1) / (k1 - k2);
//     array[1] = k2 * array[0] + b2;
//     return array; 
// }

// double k1, k2, b1, b2;
// Console.Write("Input k1: ");
// k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input b1: ");
// b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input k2: ");
// k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input b2: ");
// b2 = Convert.ToDouble(Console.ReadLine());

// double[] intersection = Intersection(k1, k2, b1, b2);
// Console.WriteLine($"intersection is ({intersection[0]}; {intersection[1]})");