// Задача 62. Напишите программу, которая заполнит спирально прямоугольный массив.

// Например, на выходе может получиться вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int ValidDirection()
{
    if ()
}

void MakeItSpiral(int[,] array)
{
    int n = 1;
    int row = 0;
    for (int col = 0; col < array.GetLength(1); col++)
    {
        array[row, col] = n;
        n++;
    }
}

int rows = 5;
int cols = 5;
int[,] arr = new int[rows, cols];


MakeItSpiral(arr);
PrintTwoDimArray(arr);