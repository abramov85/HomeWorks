// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// Console.Write("Input first number: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// int max = secondNumber;

// if (firstNumber > secondNumber)
// {
//     max = firstNumber;
// }

// Console.WriteLine(max);

// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// Console.Write("Input first number: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());
// int max;

// if (firstNumber > secondNumber)
// {
//     max = firstNumber;
// }
// else
// {
//     max = secondNumber;
// }

// if (thirdNumber > max)
// {
//     max = thirdNumber;
// }

// Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string answer = "Odd";

// if ( number % 2 == 0)
// {
//     answer = "Even";
// }

// Console.Write("nmber is ");
// Console.WriteLine(answer);

// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int current = 1;
// int sign = 1;

// if ( number <= 0 )
// {
//     sign = -1;
// }

// while ( current * sign <= number * sign )
// {
//     if ( current % 2 == 0 )
//     {
//         Console.Write(current + " ");
//     }
//     current += sign;
// }