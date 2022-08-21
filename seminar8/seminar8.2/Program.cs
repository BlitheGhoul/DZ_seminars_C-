/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Write("Введите число строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int column = int.Parse(Console.ReadLine());

int[,] myArray = new int[row, column];

Random random = new Random();



if(row != column)
{
System.Console.WriteLine("Ваш массив:");
FillArray(myArray);
PrintArray(myArray);
int number = FindMinSumAtRows(myArray);
System.Console.WriteLine("\nНомер строки с минимальной суммой: " + (number + 1));
}

else System.Console.WriteLine("Массив не прямоугольный, перезапустите программу.");

void FillArray(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
     for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
            
        }   
    }
}

void PrintArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
     for(int j = 0; j < array.GetLength(1); j++)
     {
        Console.Write(array[i, j] + "\t");
     }
     System.Console.WriteLine();
    }
}

int FindMinSumAtRows(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sums[i] += array[i, j];
        } 
    }
    int minsum = sums[0];
    int minSumRowNumber = 0;
    for(int i = 0; i < sums.Length; i++)
     if(sums[i] < minsum) 
        {
            minSumRowNumber = i;
        }
    return minSumRowNumber;
    
}

//Нумерация строк, как в примере.