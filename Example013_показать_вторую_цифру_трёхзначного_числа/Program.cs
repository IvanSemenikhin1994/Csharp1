// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 
// 782 -> 8 
// 918 -> 1

//через число int


int SecondDigitOfNumber(int number)
{
    int SecondDigit = number / 10 % 10;
    return SecondDigit;
}

System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
    System.Console.WriteLine(SecondDigitOfNumber(number));
else
    System.Console.WriteLine("Ошибка ввода. Введите трёхзначное число");


//через элемент строки char

/*string SecondDigitOfNumber(string text)
{
    string secondNumber = Convert.ToString(text[1]);
    return secondNumber;
}

System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string text = Convert.ToString(number);

if (text.Length != 3)
    System.Console.WriteLine("Ошибка ввода. Введите трёхзначное число");
else
    System.Console.WriteLine(SecondDigitOfNumber(text));
*/