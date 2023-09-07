// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день
// выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Выберите день недели: ");
Console.WriteLine("1 - понедельник");
Console.WriteLine("2 - вторник");
Console.WriteLine("3 - среда");
Console.WriteLine("4 - четверг");
Console.WriteLine("5 - пятница");
Console.WriteLine("6 - суббота");
Console.WriteLine("7 - воскресенье");

int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 8)
{
    if (num > 5)
    {
        Console.WriteLine("Да, это выходной");
    }
    else
    {
        Console.WriteLine("Нет, это будний день");
    }
}
else
{
    Console.WriteLine("Это не день недели!")
}
