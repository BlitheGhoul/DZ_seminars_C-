/* 50
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4
17 -> такого числа в массиве нет
*/



Console.Write("Введите число строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int column = int.Parse(Console.ReadLine());

int[,] myArray = new int[row, column];

Random random = new Random();

FillArray(myArray);
Console.WriteLine("Ваш массив:");
PrintArray(myArray);

System.Console.Write("Введите, через пробел, позиции элемента, который хотите получить: ");
string[] input = Console.ReadLine().Split();
int rowForPrint = int.Parse(input[0]);
int colForPrint = int.Parse(input[1]);

if(rowForPrint > row | colForPrint > column) System.Console.WriteLine("\nТакого числа нет");
else System.Console.WriteLine("\n" + "Ваше число: " + myArray[rowForPrint, colForPrint]);

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
     for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-5, 5);
            
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