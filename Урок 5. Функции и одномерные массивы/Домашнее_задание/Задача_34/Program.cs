// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArray(int n)
{
    int[] array = new int[n];
    return array;
}

void FillArray(int[] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
}

int CountEvenNum(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        count += 1;
    }
    return count;
}

int n = 10;
int minValue = 100;
int maxValue = 999;

int[] arr = CreateArray(n);
FillArray(arr, minValue, maxValue);
PrintArray(arr);

System.Console.WriteLine("");
System.Console.WriteLine($"Количество чётных чисел: {CountEvenNum(arr)}");