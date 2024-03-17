/*
12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

/*
Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 ==0)
{
    Console.WriteLine("кратно");
}
else {Console.WriteLine("не кратно " + number1 % number2);}
*/

System.Console.WriteLine("Input 1st number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input 2nd number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int ostatok = number2 % number1;

if (ostatok == 0)
{
System.Console.WriteLine("Correct");
}
else
{
System.Console.WriteLine(("Incorrect: " + ostatok));
}
