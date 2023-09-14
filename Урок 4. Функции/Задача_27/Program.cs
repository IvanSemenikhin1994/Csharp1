// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit(int num)
{
    int result = num % 10;
    while (num != 0)
    {
        num = num / 10;
        result = num % 10 + result;
    }
    return result;
}


System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{SumDigit(num)}");