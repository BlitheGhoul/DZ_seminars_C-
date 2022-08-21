/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/
System.Console.Write("Укажите количество строк массива: ");
int row = int.Parse(Console.ReadLine());
System.Console.Write("Укажите количество столбцов массива: ");
int col = int.Parse(Console.ReadLine());
System.Console.Write("Укажите количество элементов, в каждой ячейке массива: ");
int nestedRows = int.Parse(Console.ReadLine());

int [,,] myArray = new int[row, col, nestedRows];
Random random = new Random();

FillArray(myArray);
PrintArray(myArray);


void FillArray(int[,,] array)
{
    int numbers = random.Next(10, 20);
    
    
        for(int i = 0; i < array.GetLength(0); i++)
        {numbers += i;
             for(int j = 0; j < array.GetLength(1); j++)
            { numbers += j;
                for(int n = 0; n < array.GetLength(2); n++)
                {
                    numbers+= n;
                    array[i, j, n] = numbers;
            
                }  
            
            }   
    
        }
}
    

void PrintArray (int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
     for(int j = 0; j < array.GetLength(1); j++)
     {
         for(int n = 0; n < array.GetLength(2); n++)
        {
            Console.WriteLine("Значение элемента: " + array[i, j, n] + " номер его ячейки в массиве: " + "{"  + i + ", " + j + ", " + n + "}");
        }
     }
     System.Console.WriteLine();
    }
}