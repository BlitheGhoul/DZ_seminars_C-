/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

void FillingArray(double[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(1, 100);
    }
}

void PrintArray(double[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
}



Console.Write("Задайте длинну массива: ");
int arrLength = int.Parse(Console.ReadLine());


double[] array = new double [arrLength];
FillingArray(array);

double max = array[1];
double min = array[1];
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > max) max = array[i];
    else if(array[i] < min) min = array[i];
}

Console.Write("Ваш массив: [ ");
PrintArray(array);
Console.WriteLine("]");

Console.WriteLine( $"{max} - {min} = {max - min}"  );