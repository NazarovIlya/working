﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//!Математическое решение для чисел, не окончивающися нулем/нулями.
// Условию задачи является ли число палиндромом - удовлетворяет
// 100, 64540, 9000, 100000 - не являются палиндромами
// Единственный баг - в отображении подобных чисел, нули впереверку опускаются

void IsPalindrome(int N)
{
    int N2 = 0;
    int NDiv = N;
    int lastDigital = 0;

    if (N >= 0)
    {
        while (NDiv > 0)
        {
            lastDigital = NDiv % 10;
            NDiv = NDiv / 10;
            N2 = N2 * 10 + lastDigital;
        }
    }
    if (N == N2)
        Console.WriteLine($"Число {N} является палиндромом, так если прочесть его с конца, получиться {N2}");
    else if (N < 0)
        Console.WriteLine($"Число {N} не является палиндромом, так если прочесть его с конца, получиться {N}-, знак минус после числа. Палиндром не математическое понятие.");
    else
        Console.WriteLine($"Число {N} не является палиндромом, так если прочесть его с конца, получиться {N2}");
}

Console.Clear();
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
IsPalindrome(num);
