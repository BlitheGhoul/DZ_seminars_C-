//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Ваше число: " + number);
int number2 = (number / 10) % 10;
Console.WriteLine("Вторая цифра Вашего числа: " + number2);