﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ArithmProgr(int m, int n)
{
    if (m > n)
        return 0;
    return m + ArithmProgr(m + 1, n);
}

System.Console.WriteLine(ArithmProgr(m:4, n:8));