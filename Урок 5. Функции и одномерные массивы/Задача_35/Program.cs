// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123 [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] CreateArray(int n, int minValue, int maxValue)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
}

int CountDecimal(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 9 && item < 100 || item > -100 && item < -9)
        count += 1;
    }
    return count;
}

int n = 20;
int minValue = -200;
int maxValue = 200;

int[] arr = CreateArray(n, minValue, maxValue);
PrintArray(arr);
System.Console.WriteLine("");
System.Console.WriteLine($"Количество десятичных чисел: {CountDecimal(arr)}");