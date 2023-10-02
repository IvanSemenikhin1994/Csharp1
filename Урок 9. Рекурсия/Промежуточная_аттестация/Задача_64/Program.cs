// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке
// от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5" 
// M = 4; N = 8. -> "4, 6, 7, 8“

int NaturNums(int m, int n)
{
    if (m > n)
        return 1;
    System.Console.Write("{0,3 }", m);
    return NaturNums(m + 1, n);
}

NaturNums(m:4, n:8);