/*

Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую
цифру этого числа.

*/

Console.WriteLine ("ВВедите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >=100 && number <1000)
{
    int first = number / 100;
int last = number % 10;
Console.WriteLine("ответ =  " + first+last);

}
else
{
    Console.WriteLine("Это число не трехзначное");
}



