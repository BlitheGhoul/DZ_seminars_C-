/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.Write("Введите число, которое будет возводиться в степень: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("\nВведите желаемую степень: ");
int num2 = int.Parse(Console.ReadLine());
int helpNumber = num1;

for(int i = 1; i < num2; i++)
{
    num1 = num1 * helpNumber;
}
Console.WriteLine("\n Итоговое число: " + num1);

