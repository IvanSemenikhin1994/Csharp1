// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArray(int n, int minValue, int maxValue)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length)
        {
            System.Console.Write($"{array[i]}");
        }
        else
        {
            System.Console.Write($"{array[i]}, ");
        }
        
    }
}

int SumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int SumNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int n = 12;
int minValue = -9;
int maxValue = 9;

int[] array = CreateArray(n, minValue, maxValue);
PrintArray(array);
System.Console.WriteLine("");
System.Console.WriteLine($"Сумма положительных чисел: {SumPositive(array)}");
System.Console.WriteLine($"Сумма отрицательных чисел: {SumNegative(array)}");

