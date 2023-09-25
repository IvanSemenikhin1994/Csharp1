// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ= m+n.
// Выведите полученный массив на экран. 

// m = 3, n = 4. 
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


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
            array[i,j] = i + j;
        }
    }
}

int m = 3;
int n = 4;

int[,] arr = new int[m, n];
PrintArray(arr);

ChangeArray(arr);
PrintArray(arr);