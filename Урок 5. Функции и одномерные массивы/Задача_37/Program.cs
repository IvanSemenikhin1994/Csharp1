// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 12 10

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

int[] NarrowMul(int[] array)
{
    int arrMulLength = Convert.ToInt32(Math.Ceiling((float) array.Length / 2));
    int[] arrMul = new int[(int)arrMulLength];
    for (int i = 0; i < arrMulLength; i++)
    {
        if (i == array.Length - 1 - i)
        {
            arrMul[i] = array[i];
        }
        else
        {
            arrMul[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    return arrMul;
}

int n = 10;
int minValue = 1;
int maxValue = 10;

int[] arr = CreateArray(n, minValue, maxValue);
PrintArray(arr);
System.Console.WriteLine("");
System.Console.WriteLine("");
int[] arrMul = NarrowMul(arr);
PrintArray(arrMul);


