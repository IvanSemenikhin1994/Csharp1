// Задача 67:Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int DigitSum(int n)
{
    if (n < 10)
        return n;
    return n % 10 + DigitSum(n / 10);
}

System.Console.WriteLine($"Сумма цифр: {DigitSum(453)}");