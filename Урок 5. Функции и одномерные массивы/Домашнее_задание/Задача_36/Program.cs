// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int OddNumSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
}

int n = 8;
int minValue = 0;
int maxValue = 20;

int[] arr = CreateArray(n);
FillArray(arr, minValue, maxValue);
PrintArray(arr);

System.Console.WriteLine("");
System.Console.WriteLine($"Сумма элементов на нечётных позициях: {OddNumSum(arr)}");