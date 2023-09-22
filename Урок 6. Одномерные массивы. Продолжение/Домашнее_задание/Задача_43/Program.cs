// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// k1 = 5, b1 = 2, k2 = 9,  b2 = 4 -> (-0,5; -0,5)

float FindAbscissa(int b1, int k1, int b2, int k2)
{
    // k1 * x + b1 = k2 * x + b2
    // (k1 * x) - (k2 * x) = b2 - b1
    // x * (k1 - k2) = b2 - b1
    // x = (b2 - b1) / (k1 - k2)
    float x = (float)(b2 - b1) / (k1 - k2);
    return x;
}

float FindOrdinate(float x, int b1, int k1)
{
    float y = k1 * x + b1;
    return y;
}

System.Console.WriteLine("Введите переменные");
System.Console.WriteLine("y = k1 * x + b1");
System.Console.WriteLine("y = k2 * x + b2");
System.Console.WriteLine();

System.Console.WriteLine("Введите k1");
int k1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите b1");
int b1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите k2");
int k2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите b2");
int b2 = int.Parse(Console.ReadLine()!);

if (k1 == k2 && b1 == b2)
    System.Console.WriteLine("Функции равны между собой");
else
{
    if (k1 == k2)
        System.Console.WriteLine("Прямые параллельны. Пересечения не будет");
    else
    {
        float x = FindAbscissa(b1, k1, b2, k2);
        float y = FindOrdinate(x, b1, k1);
        System.Console.WriteLine($"Координаты точки пересечения: [{x:F1}; {y:F1}]");
    }
}