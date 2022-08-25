/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());
int count = 0;

Numbers(m, n, count);

void Numbers(int first, int second, int count)
{
  
    if(first > second)
    {
        System.Console.WriteLine(count);
        return;
    } 
    else
    {
        count+= first;
        first++;
        Numbers(first, second, count);
    }
    

}