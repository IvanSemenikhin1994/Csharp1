// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void SwapNumeralSign(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1; 
    }
}


int[] arr = CreateArray(n:12, minValue:-9, maxValue:9);
PrintArray(arr);
SwapNumeralSign(arr);
System.Console.WriteLine("");
PrintArray(arr);
