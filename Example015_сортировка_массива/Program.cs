Console.Clear();
int[] array = new int[] {1,6,8,2,4,6,78,8,34,23};

void PrintArray(int[] array)
{
    System.Console.WriteLine("");
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
}

// от меньшего к большему

/*

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MinPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MinPosition])
            {
                MinPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[MinPosition];
        array[MinPosition] = temp;
    }
    return array;
}

*/

// от большего к меньшему

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MaxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[MaxPosition])
            {
                MaxPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[MaxPosition];
        array[MaxPosition] = temp;
    }
    return array;
}

PrintArray(array);
int[] SortedArray = SortArray(array);
PrintArray(SortedArray);
