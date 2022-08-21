/*
Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

int row = 4;
int col = 4;
int[,] myArray = new int[row, col];
int counter = 0;
for(int i = 0; i < row; i++)
{
    for(int j = 0; j < col; j++)
    {   counter++;
        if(i == 0 & j < row) myArray[i, j] = counter; 
        if(i > 0 & j == row - 1) myArray[i, j] = (counter / (i + 1)) + i;
        
    }
}

int counter2 = 0;
for(int i = row - 1; i >= 0; i--)
{
    for(int j = col / 2; j  >= 0; j--)
    {
       
        if(i == row - 1)
        {
            myArray[i, j] = counter / 2 + counter2;
        }    
        counter2++;
    }   
}

for(int i = 0; i < row; i++)
{
    for(int j = 0; j  < col; j++)
    {
        if(myArray[i,j] == 0)
        {

            if(i == row / row)
            {
                myArray[i,j] = counter2 + j;
                
            }
        }
    }
}

for(int i = row / 2; i >= 0; i--)
{
    for(int j = 0; j <   col - 1; j++)
    {
        if(myArray[i,j] == 0)
        {

            if(j == 0) 
            {
            System.Console.WriteLine("Первый вывод counter2: " + counter2);
               myArray[i,j] = counter2 - 1;
                counter2 = counter2 - counter2;
            }
            else
            {
                myArray[i,j] = counter - counter2;
                counter2++;
            }
         
        }
    }

}

System.Console.WriteLine(counter);
System.Console.WriteLine("counter2: " + counter2);
PrintArray(myArray);






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