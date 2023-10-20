/*

Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

using System.Reflection.Metadata;

Console.WriteLine("Введите трехзначное число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

if (NumberA >= 100 && NumberA <1000)
{
int answer = NumberA % 10;


    Console.WriteLine("Последняя цифра числа: " + answer);

}
else 
{Console.WriteLine ("Число не является трехначным");
}