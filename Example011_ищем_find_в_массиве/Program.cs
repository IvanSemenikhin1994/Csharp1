/*
int[] array = {31,27,53,64,58,6,76,64};

int n = array.Length;
int find = 64;

int index = 0;

while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
*/

void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
    collection[index] = new Random().Next(1, 10);
    index++;
}
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(position);
        position++;
    }
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);

