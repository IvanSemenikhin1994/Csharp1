//ввести диапазон чисел
Console.WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());

/*
if (a == 1)
{
    Console.WriteLine("Понедельник");
}
if (a == 2)
{
    Console.WriteLine("Вторник");
}
if (a == 3)
{
    Console.WriteLine("Среда");
}
if (a == 4)
{
    Console.WriteLine("Четверг");
}
if (a == 5)
{
    Console.WriteLine("Пятница");
}
if (a == 6)
{
    Console.WriteLine("Суббота");
}
if (a == 7)
{
    Console.WriteLine("Воскресенье");
}
*/

switch (a)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Ошибка ввода");
        break;
}
