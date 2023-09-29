// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку
// массива. Модификация: любые заданные строчки массива

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

// void ChangeTwoDimArrayV1(int[,] twoDimArray)
// {
//     for (int j = 0; j < twoDimArray.GetLength(1); j++)
//     {
//         int temp = twoDimArray[0, j];
//         twoDimArray[0, j] = twoDimArray[twoDimArray.GetLength(0) - 1, j];
//         twoDimArray[twoDimArray.GetLength(0) - 1, j] = temp;
//     }
// }

void ChangeTwoDimArrayV2(int[,] twoDimArray, int s1, int s2)
{
    for (int j = 0; j < twoDimArray.GetLength(1); j++)
    {
        int temp = twoDimArray[s1 - 1, j];
        twoDimArray[s1 - 1, j] = twoDimArray[s2 - 1, j];
        twoDimArray[s2 - 1, j] = temp;
    }
}

int[,] twoDimArr = CreateTwoDimArray();
PrintTwoDimArray(twoDimArr);

System.Console.WriteLine("Выберите строки: ");
int s1 = int.Parse(Console.ReadLine()!);
int s2 = int.Parse(Console.ReadLine()!);

ChangeTwoDimArrayV2(twoDimArr, s1, s2);
PrintTwoDimArray(twoDimArr);