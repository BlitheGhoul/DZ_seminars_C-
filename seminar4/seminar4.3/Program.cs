/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

void fillingArray(int[] a, int b, int c)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(b,c);
    }
}
void printArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
}

Console.Write("Эта программа создаст  и выведет на экран массив из 8 случайных элементов, но ей нужно немного помочь. \nВведите минимальное число массива(ОТ какого числа будет начинаться выборка): ");
int min = int.Parse(Console.ReadLine());
Console.Write("\nОтлично!\n \nА теперь введите максимальное число массива(ДО какого числ будет браться выборка): ");
int max = int.Parse(Console.ReadLine()) + 1;

int[] array = new int[8];
fillingArray(array, min, max);
Console.Write("\nВаш массив готов: [ ");
printArray(array);
Console.Write("]");

