// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

HashSet<int> numbers = new HashSet<int>();
Random r = new Random();

int GenerateUniqueNumber()
{
    while (true)
    {
        var n = r.Next(10, 100);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;
        }
    }
}

void PrintThreeDimArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,,] CreateThreeDimArray(int rows = 2, int cols = 2, int heights = 2)
{
    int[,,] array = new int[rows, cols, heights];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < heights; k++)
            {
                array[i, j, k] = GenerateUniqueNumber();
            }
        }
    }
    return array;
}

int[,,] arr = CreateThreeDimArray();

PrintThreeDimArray(arr);