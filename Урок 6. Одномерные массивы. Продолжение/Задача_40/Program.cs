// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины. 
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/*

void PrintArray(int[] array)
{
    System.Console.WriteLine();
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
}

bool IsTriangle(int[] abc)
{
    if (abc[0] < abc[1] + abc[2] && abc[1] < abc[0] + abc[2] && abc[2] < abc[0] + abc[1])
        return true;
    else
        return false;
}

int[] abc = new int[3];
System.Console.WriteLine($"Введите длину первой стороны: ");
abc[0] = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Введите длину второй стороны: ");
abc[1] = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Введите длину третьей стороны: ");
abc[2] = int.Parse(Console.ReadLine()!);

PrintArray(abc);

if (IsTriangle(abc) == true)
    System.Console.WriteLine("Да, такой треугольник существует");
else
    System.Console.WriteLine("Нет, такого треугольника не существует");

*/

// для многоугольника


void PrintArray(int[] array)
{
    System.Console.WriteLine();
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
}

// bool IsPolygonValidV1(int[] abc)
// {
//     for (int i = 0; i < abc.Length; i++)
//     {
//         int sumOthers = 0;
//         for (int j = 0; j < abc.Length; j++)
//         {
//             if (j != i)
//                 sumOthers += abc[j];
//         }
//         if (abc[i] >= sumOthers)
//             return false;
//     }
//     return true;
// }

bool IsPolygonValidV2(int[] abc)
{
    int sumAll = 0;
    for (int i = 0; i < abc.Length; i++)
    {
        sumAll += abc[i];
    }
    for (int i = 0; i < abc.Length; i++)
    {
        if (abc[i] >= sumAll - abc[i])
            return false;
    }
    return true;
}

int[] abc = { 4, 2, 7, 2, 76 };

PrintArray(abc);

if (IsPolygonValidV2(abc) == true)
    System.Console.WriteLine("Да, такой многоугольник существует");
else
    System.Console.WriteLine("Нет, такого многоугольника не существует");
