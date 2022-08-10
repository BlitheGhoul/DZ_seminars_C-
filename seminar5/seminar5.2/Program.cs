/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

void FillingArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
}


Console.Write("Задайте длинну массива: ");
int arrLength = int.Parse(Console.ReadLine());


int[] array = new int [arrLength];
FillingArray(array);

int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0) sum += array[i];
}

Console.Write("Ваш массив: [ ");
PrintArray(array);
Console.WriteLine("]");

Console.WriteLine("\nСумма всех нечетных элементов: " + sum);