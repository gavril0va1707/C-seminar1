/*
Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

int start = 1;

while (start <= NumberA)
{

start = start + 1;

if (start % 2 ==0)
{
Console.WriteLine(start);
}
}