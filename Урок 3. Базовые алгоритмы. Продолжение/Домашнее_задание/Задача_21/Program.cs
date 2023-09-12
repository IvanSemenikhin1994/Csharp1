// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты
// двух точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
int[] ReadPointCoords()
{
    System.Console.WriteLine("x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("z: ");
    int z = Convert.ToInt32(Console.ReadLine());
    int[] Coords = new int[] { x, y, z };
    return Coords;
}

double DistanceBetweenPoints(int[] PointA, int[] PointB)
{
    int x1 = PointA[0];
    int y1 = PointA[1];
    int z1 = PointA[2];
    int x2 = PointB[0];
    int y2 = PointB[1];
    int z2 = PointB[2];
    double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return distance;
}


System.Console.WriteLine("Введите коородинаты первой точки: ");
int[] PointA = ReadPointCoords();
System.Console.WriteLine("Введите коородинаты второй точки: ");
int[] PointB = ReadPointCoords();

System.Console.WriteLine($"{DistanceBetweenPoints(PointA, PointB):F2}");
*/

using System;
public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже


    int x1 = pointA[0];
    int y1 = pointA[1];
    int z1 = pointA[2];
    int x2 = pointB[0];
    int y2 = pointB[1];
    int z2 = pointB[2];
    double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return distance;

    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}