/*
9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8

*/


int number = new Random().Next(10, 100);
Console.WriteLine(number);

int first = number / 10;
int second = number % 10;
int max = first;

if(second > first)
{
    max = second;
}
Console.WriteLine(max);

// 2 var
if(first > second)
    Console.WriteLine(first);
else
    Console.WriteLine(second);
