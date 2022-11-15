// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNums(int n)
// {
//     if(n > 1)
//     {
//         Console.Write(n + ", ");
//         ShowNums(n - 1);
//     }
//     else Console.WriteLine(n);
// }

// Console.WriteLine("Inpit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ShowNums(num);

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumBetween(int m, int n)
// {
//     if(m < n) return SumBetween(m + 1, n - 1) + m + n; //решил что прибавляя с двух сторон будет в 2 раза меньше рекурсий
//     if(m > n) return SumBetween(m - 1, n + 1) + m + n; //если учесть что первое число может быть больше второго, то не понятно как получить 0 когда они равны
//     else return m;
// }

// int sumBtw = SumBetween(8, 4);
// Console.WriteLine(sumBtw);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Akkerman(int m, int n) //просто взял определение функции, и описал
// {
//     if(m == 0) return n + 1;
//     if(m > 0 && n == 0) return Akkerman(m - 1, 1);
//     if(m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
//     else return 0;
// }

// int res = Akkerman(3, 2);
// Console.WriteLine(res);