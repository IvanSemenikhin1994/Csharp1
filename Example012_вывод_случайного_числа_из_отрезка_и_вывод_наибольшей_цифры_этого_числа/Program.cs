// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа. 
// 78 -> 8 12-> 2 85 -> 8

// вывод случайного числа из отрезка

int GetRandomNumber(int minValue = 10, int maxValue = 99)
{
    return new Random().Next(minValue, maxValue + 1);
}

int GetMaxDigit(int GetTwoDigitNumber)
{
    int digit1 = GetTwoDigitNumber / 10;
    int digit2 = GetTwoDigitNumber % 10;

    // if (digit1 > digit2)
    //     return digit1;
    // else
    //     return digit2;
    return digit1 > digit2 ? digit1 : digit2;
}
int a = GetRandomNumber();

System.Console.WriteLine(a);
System.Console.WriteLine(GetMaxDigit(a));

//System.Console.WriteLine(GetRandomNumber(/*minValue:50, maxValue:150*/));
