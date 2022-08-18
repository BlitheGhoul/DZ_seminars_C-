/* 52
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("Введите число строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int column = int.Parse(Console.ReadLine());

int[,] myArray = new int[row, column];

Random random = new Random();
double[] average = new double[column];

FillArray(myArray);
Console.WriteLine("Ваш массив:");
PrintArray(myArray);



Console.WriteLine("Среднее арифметическое в каждом столбце:");
PrintAverage(average);



void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
     for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 8);
            average[j] += array[i,j];
            
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
void PrintAverage(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Столбец " + i + " среднее арифметическое: " + Math.Round(array[i] / row, 1));
    }
}