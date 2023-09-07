// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 
// 782 -> 8 
// 918 -> 1


int SecondDigitOfNumber(int number)
{
    int SecondDigit = number / 10;
    int SecondDigit1 = SecondDigit % 10;
    return SecondDigit1;
}

System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SecondDigitOfNumber(number));

