// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count += 1;
    }
    return count;
}

int m = 10;

System.Console.WriteLine("Введите числа:");
int[] numbers = new int[m];

System.Console.WriteLine();
FillArray(numbers);
System.Console.WriteLine();
PrintArray(numbers);

System.Console.WriteLine();
System.Console.WriteLine($"Количество положительных чисел: {CountPositive(numbers)}");

