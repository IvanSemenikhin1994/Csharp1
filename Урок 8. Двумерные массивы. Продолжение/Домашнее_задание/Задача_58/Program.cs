// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] CreateMulMatrix(int[,] arr1, int[,] arr2)
{
    int rowLength = arr1.GetLength(0);
    int colLength = arr1.GetLength(1);
    if (arr1.GetLength(0) < arr2.GetLength(0))
        rowLength = arr2.GetLength(0);
    if (arr1.GetLength(1) < arr2.GetLength(1))
        colLength = arr2.GetLength(1);

    int[,] arrMul = new int[rowLength, colLength];
    return arrMul;
}

/*

int SumMatrixMul(int[,] matrix, int[,] arr1, int[,] arr2, int row, int col)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += arr1[row, i] * arr2[i, col];
    }
    return sum;
}

int[,] MatrixMul(int[,] arrMul, int[,] arr1, int[,] arr2)
{
    for (int i = 0; i < arrMul.GetLength(0); i++)
    {
        for (int j = 0; j < arrMul.GetLength(1); j++)
        {
            arrMul[i, j] = SumMatrixMul(arrMul, arr1, arr2, i, j);
        }
    }
    return arrMul;
}

*/

int[,] MatrixMulV2(int[,] arrMul, int[,] arr1, int[,] arr2)
{
    int sum = 0;
    for (int i = 0; i < arrMul.GetLength(0); i++)
    {
        for (int j = 0; j < arrMul.GetLength(1); j++)
        {
            for (int k = 0; k < arrMul.GetLength(0); k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            arrMul[i, j] = sum;
            sum = 0;
        }
    }
    return arrMul;
}

bool MulMatrixValid(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) != arr2.GetLength(0))
    {
        System.Console.WriteLine("Такие матрицы нельзя перемножить. Количество столбцов матрицы А неравно количеству строк матрицы B");
        return false;
    }
    return true;
}


int[,] arr1 = new int[,] { { 2, 4 },
                           { 3, 2 } };

int[,] arr2 = new int[,] { { 3, 4 },
                           { 3, 3 } };
PrintTwoDimArray(arr1);
PrintTwoDimArray(arr2);

if (MulMatrixValid(arr1, arr2))
    {
    int[,] arrMul = CreateMulMatrix(arr1, arr2);
    arrMul = MatrixMulV2(arrMul, arr1, arr2);
    PrintTwoDimArray(arrMul);
    }