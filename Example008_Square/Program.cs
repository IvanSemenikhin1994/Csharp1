Console.WriteLine("Введите число ");
int number = Convert.ToInt32( Console.ReadLine() );
int answer = number * number;
Console.WriteLine("1 вариант. Квадрат числа " + number + " равен " + answer);
Console.WriteLine($"2 вариант. Квадрат числа {number} равен {answer}");