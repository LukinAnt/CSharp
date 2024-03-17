/*
Напишите программу, которая  на вход принимает число и выдает, является ли число четным(желится ли на 2 без остатка)
 4
 -3
 7
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv = number % 2;

if(remDiv == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}