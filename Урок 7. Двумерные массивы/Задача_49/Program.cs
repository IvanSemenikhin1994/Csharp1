// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы
// на их квадраты. 
// Например, изначально массив выглядел вот так: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Новый массив будет выглядеть вот так: 
// 1 4 7 2 
// 5 81 2 9 
// 8 4 2 4

int[,] CreateArray(int rows, int cols, int minValue = 4, int maxValue = 9)
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

void PrintArray(int[,] array)
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

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
                array[i, j] *= array[i, j];
        }
    }
}

int n = 5;
int m = 6;

int[,] arr = CreateArray(n, m);
PrintArray(arr);

ChangeArray(arr);
PrintArray(arr);