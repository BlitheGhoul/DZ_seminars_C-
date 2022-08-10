/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21
*/



Console.Write("Задайте длинну массива: ");
int arrLength = int.Parse(Console.ReadLine());


int[] array = new int [arrLength];
FillingArray(array);

int[] result = FillingResult(array);


Console.Write("Ваш первичный массив: [ ");
PrintArray(array);
Console.WriteLine("]");

Console.Write("\nМассив произведений: [ ");
PrintArray(result);
Console.WriteLine("]");



void FillingArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
}

int[] FillingResult(int[] a)
{
    int resLength = 0;
if(a.Length % 2 == 0)
{
    resLength = a.Length / 2;
}

else
{
     resLength = (a.Length / 2) + 1;
}
 
 int[] res = new int [resLength];

if(a.Length % 2 == 0)
{
     for(int i = 0, j = a.Length - 1; i < a.Length / 2; i++, j--)
    {
        res[i] = a[i] * a[j];
    }
}
else
{
    for(int i = 0, j = a.Length - 1; i < a.Length / 2 ; i++, j--)
    {
        res[i] = a[i] * a[j];
    }
    res[a.Length / 2] = a[a.Length / 2];
}
return res;
}