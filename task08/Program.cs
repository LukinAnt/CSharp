﻿/*
Напишите программу, которая на вход принимает число (N) и на выходе показывает все четные числа от 1 до N

 5->2 4
 8->2 4 6 8

*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int number2 = 2;

if(number > 1)
{
    while(number2 <= number)
    {
        Console.Write(number2 + " ");
        number2 = number2 + 2;
    }
}

