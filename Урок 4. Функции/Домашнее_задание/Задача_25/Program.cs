// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow(int num, int exp)
{
    int result = num;
    if (exp == 0)
    {
        return result = 1;
    }
    for (int i = 0; i < exp - 1; i++)
    {
        result *= num;
    }
    return result;
}

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень числа: ");
int exp = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{Pow(num, exp)}");