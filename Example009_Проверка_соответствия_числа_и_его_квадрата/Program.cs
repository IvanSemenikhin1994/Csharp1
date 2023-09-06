//приглашение к вводу, ввод двух чисел
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

//проверка двух чисел. Является ли первое квадратом второго
if (a == b * b)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}