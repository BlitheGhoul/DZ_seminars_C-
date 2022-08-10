/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
void FillingArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(100, 1000);
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
for (int j = 0; j < array.Length; j++)
{
    if(array[j] % 2 == 0) sum++;
}

PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine(sum);