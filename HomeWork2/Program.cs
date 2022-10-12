// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
int FindSecondDigit(int num)
{
    return num / 10 % 10;
}

int number = new Random().Next(100, 1000);

Console.WriteLine($"{number} -> {FindSecondDigit(number)}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
int CountDigit(int num)
{
    int count = 1;
    while (num > 9)
    {
        num = num / 10;
        count++;
    }
    return count;
}

void FindThirdDigit(int n)
{
    int count = CountDigit(n);
    while (count > 3)
    {
        n = n / 10;
        count--;
    }

    n = n % 10;

    if (count < 3)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        Console.WriteLine(n);
    }
}

// int number = new Random().Next(1, 10000);
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"{number} -> ");
FindThirdDigit(number);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
/*
void IsWeekend (int day)
{
    if (day <= 5)
    {
        Console.WriteLine("Рабочий день.");
    }
    else
    {
        Console.WriteLine("Выходной день!");
    }
}

int dayOfWeek = new Random().Next(1, 8);
Console.WriteLine(dayOfWeek);
IsWeekend(dayOfWeek);
*/
