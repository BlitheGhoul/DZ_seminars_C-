/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num >= 100 & num < 1000)
{
Console.WriteLine("Третья цифра Вашего числа: " + num % 10);
}

else if (num >= 1000 & num < 10000)
{
Console.WriteLine("Третья цифра Вашего числа: " + (num % 100) / 10);
}

else if (num >= 10000 & num < 100000)
{
Console.WriteLine("Третья цифра Вашего числа: " + (num % 1000) / 100);
}

else if (num >= 100000 & num < 1000000)
{
Console.WriteLine("Третья цифра Вашего числа: " + (num % 10000) / 1000);
}

else if (num >= 1000000 & num < 10000000)
{
Console.WriteLine("Третья цифра Вашего числа: " + (num % 100000) / 10000);
}

else if (num >= 10000000 & num < 100000000)
{
Console.WriteLine("Третья цифра Вашего числа: " + (num % 1000000) / 100000);
}

else if (num >= 100000000 & num < 1000000000)
{
Console.WriteLine("Третья цифра Вашего числа: " + (num % 10000000) / 1000000);
}

else if (num >= 1000000000 & num < 10000000000)
{
Console.WriteLine("Третья цифра Вашего числа: " + (num % 100000000) / 10000000);
}

else 
{
    Console.WriteLine("Третьей цифры нет");
}