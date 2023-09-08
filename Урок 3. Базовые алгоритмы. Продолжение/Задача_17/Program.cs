// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится
// эта точка.


int NumberQuaterOfPlane(int x1, int y1)
{
    int result = -1;

    if (x1 == 0 || y1 == 0)
    {
        System.Console.WriteLine("Ошибка. x и y не могут быть равны нулю");
        return result;
    }
    else
    {
        if (x1 > 0 && y1 > 0)
        {
            result = 1;
            return result;
        }
        if (x1 < 0 && y1 > 0)
        {
            result = 2;
            return result;
        }
        if (x1 < 0 && y1 < 0)
        {
            result = 3;
            return result;
        }
        if (x1 > 0 && y1 < 0)
        {
            result = 4;
            return result;
        }
        return result;
    }


    /*

    int result = 0;

    if (x1 > 0 && y1 > 0)
    {
        result = 1;
        return result;
    }
    if (x1 < 0 && y1 > 0)
    {
        result = 2;
        return result;
    }
    if (x1 < 0 && y1 < 0)
    {
        result = 3;
        return result;
    }
    if (x1 > 0 && y1 < 0)
    {
        result = 4;
        return result;
    }

    System.Console.WriteLine("Ошибка. x и y не могут быть равны нулю");
    return result;

    */

}


System.Console.WriteLine("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(NumberQuaterOfPlane(x, y));