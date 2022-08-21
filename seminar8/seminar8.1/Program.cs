/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию
 элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

1 2 4 7
2 3 5 9
2 4 4 8
*/

Console.Write("Введите число строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int column = int.Parse(Console.ReadLine());

int[,] myArray = new int[row, column];

Random random = new Random();

System.Console.WriteLine("Первоначальный массив:");
FillArray(myArray);
PrintArray(myArray);

System.Console.WriteLine("\nМассив, с элементами в порядке убывания(не как в примере):");
ShiftArray(myArray);
PrintArray(myArray);

void ShiftArray(int[,] array)
{
    int shift = 0;
    for(int counter = 0; counter != array.GetLength(1); counter++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(j == 0)
                {
                    if(array[i, j] < array[i, j + 1])
                    {
                        shift = array[i, j];
                        array[i, j] = array[i, j + 1];
                        array[i, j + 1] = shift;
                    }
                }
                else
                {
                    if(array[i, j] > array[i, j - 1])
                    {
                        shift = array[i, j];
                        array[i, j] = array[i, j - 1];
                        array[i, j - 1] = shift;
                    }
                }
         
            }
        }
    }
}

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