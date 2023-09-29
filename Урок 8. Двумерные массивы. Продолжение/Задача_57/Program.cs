// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию
// о том, сколько раз встречается элемент входных данных.


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

int[,] CreateTwoDimArray(int rows, int cols, int minValue, int maxValue)
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

int CountAmountOfNums(int[,] matrix, int value)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == value)
                count++;
        }
    }
    return count;
}

void FillArray(int[] array, int[,] matrix, int minValue)
{
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = CountAmountOfNums(matrix, minValue);
            minValue++;
        }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void PrintStringArr(string[] arr, int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] == 0)
            continue;
        System.Console.WriteLine(arr[i]);
    }
}

void FillStringArray(string[] strArr, int[] arr, int minValue)
{
    for (int i = 0; i < strArr.Length; i++)
    {
        strArr[i] = $"Число {minValue} встречается {arr[i]} раз";
        minValue++;
    }
}

// string[] CountMemoList(int[,] array)
// {
//     string[] stringArr = new string[];
//     feturn stringArr;
// }

int minValue = -5;
int maxValue = 9;

int[,] matrix = CreateTwoDimArray(rows:3, cols:4, minValue, maxValue);
PrintTwoDimArray(matrix);

int[] countValuesArr = new int[maxValue - minValue + 1];
FillArray(countValuesArr, matrix, minValue);
PrintArray(countValuesArr);
System.Console.WriteLine();

string[] stringArr = new string[countValuesArr.Length];
FillStringArray(stringArr, countValuesArr, minValue);
PrintStringArr(stringArr, countValuesArr);