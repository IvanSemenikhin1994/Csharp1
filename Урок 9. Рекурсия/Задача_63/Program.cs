﻿// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке
// от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int Func(int k, int n)
{
    if (k > n)
    {
        return 1;
    }
    System.Console.Write("{0,3 }", k);
    return Func(k + 1, n);
}

Func(1, 20);