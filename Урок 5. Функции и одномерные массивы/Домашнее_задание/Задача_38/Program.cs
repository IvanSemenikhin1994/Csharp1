// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов
// массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArray(int n)
{
    double[] array = new double[n];
    return array;
}

void FillArray(double[] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * ((double) maxValue - minValue)  + minValue;
    }
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        System.Console.WriteLine(item);
    }
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

int n = 7;
int minValue = 10;
int maxValue = 20;

double[] arr = CreateArray(n);
FillArray(arr, minValue, maxValue);
PrintArray(arr);

System.Console.WriteLine("");
System.Console.WriteLine($"Максимальный элемент: {FindMax(arr)}");
System.Console.WriteLine($"Минимальный элемент: {FindMin(arr)}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементом: {(FindMax(arr) - FindMin(arr)):f}");
System.Console.WriteLine("");
