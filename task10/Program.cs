/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
в которой находится эта точка.
НЕРЕШЕНА
*/

Console.WriteLine("Введите два числа: ");
int x = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());


//Console.Write('x = '); readln (x);
//Console.Write('y = '); readln (y);

    if (x > 0) and (y > 0)
    {
        Console.Write('Четверть I');
    }
    else if (x < 0) and (y > 0)
    {
        Console.Write('Четверть II');
    }
    else if (x < 0) and (y < 0)
    {
        Console.Write('Четверть III');
    }
    else if (x > 0) and (y < 0)
    {
        Console.Write('Четверть IV');
    }
    else
    Console.Write("Точка лежит на оси");
