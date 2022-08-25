/*
Задача 64: Задайте значения M и N.
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

Numbers(m, n);

void Numbers(int first, int second)
{
    if(first > second) return;
    else
    {
        System.Console.WriteLine(first);
        first++;
        Numbers(first, second);
    }
}