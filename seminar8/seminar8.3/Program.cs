/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

Console.Write("Введите количество строк и столбцов, для первой матрицы, через пробел: ");
string[] firstInput = Console.ReadLine().Split();
int firstRow = int.Parse(firstInput[0]);
int firstCol = int.Parse(firstInput[1]);

Console.Write("Введите количество строк и столбцов, для второй матрицы, через пробел: ");
string[] secondInput = Console.ReadLine().Split();
int secondRow = int.Parse(secondInput[0]);
int secondCol = int.Parse(secondInput[1]);

int[,] firstMatrix = new int[firstRow, firstCol];
int[,] secondMatrix = new int[secondRow, secondCol];
Random random = new Random();

if(firstCol != secondRow)
{
    Console.WriteLine("\n Количество столбцов первой матрицы не равно количеству строк второй матрицы. Умножение не возможно. Перезапустите программу.");
return;
}
else
{
FillArray(firstMatrix);
FillArray(secondMatrix);

System.Console.WriteLine("\nПервая матрица:");
PrintArray(firstMatrix);

System.Console.WriteLine("\nВторая матрица:");
PrintArray(secondMatrix);

System.Console.WriteLine("Результат умножения:");
PrintArray(Multiplication(firstMatrix, secondMatrix));
}


void FillArray(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
     for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 6);
            
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

int[,] Multiplication(int[,] array1, int[,] array2)
{
int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
for(int i = 0; i < array3.GetLength(0); i++)
{
    for(int j = 0; j < array3.GetLength(1); j++)
    {
        for(int n = 0; n < array3.GetLength(1); n++)
        array3[i, j] += array1[i,n] * array2[n, j];
    }
}
return array3;
}