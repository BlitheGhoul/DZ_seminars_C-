/* 47
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

Console.Write("Введите число строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int column = int.Parse(Console.ReadLine());

double[,] myArray = new double[row, column];

Random random = new Random();

FillArray(myArray);
PrintArray(myArray);

void FillArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
     for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.Next(-5, 5) + random.NextDouble(), 2);
            
        }   
    }
}

void PrintArray (double[,] array)
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