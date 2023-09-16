// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет-3;массив [6, 7, 19, 345, 3] -> да

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

bool ValidateNumber(int minValue, int maxValue, int a)
{
    if (a >= minValue && a <= maxValue)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool NumberCheck(int[] array, int a)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (a == array[i])
        {
            return true;
        }
    }
    return false;
}


int minValue = -9;
int maxValue = 9;
int[] arr = CreateArray(n: 12, minValue, maxValue);
PrintArray(arr);
System.Console.WriteLine("");
System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (ValidateNumber(minValue, maxValue, a))
{
    if (NumberCheck(arr, a))
    {
        System.Console.WriteLine("Искомое число найдено");
    }
    else
    {
        System.Console.WriteLine("Искомое число не найдено");
    }
}
else
{
    System.Console.WriteLine("Ошибка ввода. Число за рамками значения массива");
}








