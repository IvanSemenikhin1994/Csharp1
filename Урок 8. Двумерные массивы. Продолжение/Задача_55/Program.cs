// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести сообщение для пользователя.

void PrintTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] CreateTwoDimArray(int rows = 5, int cols = 5, int minValue = 0, int maxValue = 9)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void ChangeRowsToCols(int[,] twoDimArray)
{
    int pivot = 0;
    int maxLength = twoDimArray.GetLength(0);
    if (maxLength > twoDimArray.GetLength(1))
        maxLength = twoDimArray.GetLength(1);
    for (pivot = 0; pivot < maxLength; pivot++)
    {
        for (int i = pivot + 1; i < maxLength; i++)
        {
            int temp = twoDimArray[pivot, i];
            twoDimArray[pivot, i] = twoDimArray[i, pivot];
            twoDimArray[i, pivot] = temp;
        }
    }
}

int[,] twoDimArr = CreateTwoDimArray();
PrintTwoDimArray(twoDimArr);

ChangeRowsToCols(twoDimArr);
PrintTwoDimArray(twoDimArr);