/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница
*/

Console.WriteLine("Введите число от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 1)
{
    Console.WriteLine("Сегодня понедельник");

}
if (dayNumber == 2)
{
    Console.WriteLine("Сегодня вторник");

}

if (dayNumber == 3)
{
    Console.WriteLine("Сегодня среда");

}

if (dayNumber == 4)
{
    Console.WriteLine("Сегодня четверг");

}
if (dayNumber == 5)
{
    Console.WriteLine("Сегодня пятница");

}
if (dayNumber == 6)
{
    Console.WriteLine("Сегодня суббота");

}
if (dayNumber == 7)
{
    Console.WriteLine("Сегодня воскресение");

}
