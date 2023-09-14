// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] RandomArray(int n)
{
    int [] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            System.Console.Write($"[{array[i]}, ");
        }
        if (i == 4)
        {
            System.Console.Write($"{array[i]}]");
            System.Console.WriteLine("");
        }
        if (i == 5)
        {
            System.Console.Write($"[{array[i]}, ");
        }
        if (i != 0 && i != 4 && i != 5 && i != 7)
        {
            System.Console.Write($"{array[i]}, ");
        }
        if (i == 7)
        {
            System.Console.Write($"{array[i]}]");
        }
    }
}

// int[] array = new int[] {1,141,1,16,1,1,5436,78,568,123,312,31,24};
int n = 8;
int[] array = RandomArray(n);
PrintArray(array);