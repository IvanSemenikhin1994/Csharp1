// Задача 59: Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Наименьший элемент -1, на выходе получим следующий массив:

// 9 2 3
// 4 2 4
// 2 6 7


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

int[,] RemoveRowAndCol(int[,] array, int row, int col)
{
    int[,] res = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            int stepi = 0, stepj = 0;
            if (i >= row)
                stepi = 1;
            if (j >= col)
                stepj = 1;
            res[i, j] = array[i + stepi, j + stepj];
        }
    }
    return res;
}

int[,] array = CreateTwoDimArray();
PrintTwoDimArray(array);

int[,] res = RemoveRowAndCol(array, 2, 2);
PrintTwoDimArray(res);