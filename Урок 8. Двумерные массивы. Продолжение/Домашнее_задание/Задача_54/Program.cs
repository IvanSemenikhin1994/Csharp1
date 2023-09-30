// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой
// строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintTwoDimArray(int[,] array)
{
    // индекс столбцов
    // for (int i = 0; i < array.GetLength(1); i++)
    // {
    //     System.Console.Write("\t" + i);
    // }
    // System.Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        // System.Console.Write(i + "\t"); // индекс строк
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] CreateTwoDimArray(int rows = 4, int cols = 5, int minValue = 0, int maxValue = 9)
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

void SortMatrixRow(int[,] array) //от большего к меньшему
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int maxPositionRow = i;
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPositionCol = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {

                if (array[i, k] > array[maxPositionRow, maxPositionCol])
                {
                    maxPositionCol = k;
                }
            }
            int temp = array[i, j];
            array[i, j] = array[maxPositionRow, maxPositionCol];
            array[maxPositionRow, maxPositionCol] = temp;
            maxPositionCol = 0;
        }
        maxPositionRow++;
    }
}

int[,] matrix = CreateTwoDimArray();
PrintTwoDimArray(matrix);

SortArray(matrix);
PrintTwoDimArray(matrix);