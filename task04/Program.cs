﻿/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int NumberC = Convert.ToInt32(Console.ReadLine());

int max = NumberA;

if (NumberA > max)
{
    max = NumberA;
}
if (NumberB > max) 
{
max = NumberB;
}
if (NumberC > max) 
{
max = NumberC;
}
Console.WriteLine("max = " + max);


