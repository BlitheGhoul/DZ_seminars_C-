/* 
Дополнительное задание: Напишите программу, которая принимает на вход число N и выводит все простые числа
в промежутке от 0 до N (включительно). После, попробуйте поэксперментировать с величиной значения N и 
понаблюдать за тем, как оно влияет на время выполнения программы.
*/
Console.Write("Введите число, вплоть до которого будут выводиться простые числа: ");
int num = int.Parse(Console.ReadLine());
int[] arr1 = new int[num];
int size = num;
int count = 0;
while (count < size)
{
    arr1[count] = count + 1;
    if (arr1[count] == 2)
    {
        Console.WriteLine(arr1[count]);
    }
    else if (arr1[count] == 3)
    {
        Console.WriteLine(arr1[count]);
    }
     else if (arr1[count] == 5)
    {
        Console.WriteLine(arr1[count]);
    }
     else if (arr1[count] == 7)
    {
        Console.WriteLine(arr1[count]);
    }
     else if (arr1[count] % 2 != 0 & arr1[count] % 3 != 0 & arr1[count] % 4 != 0 & arr1[count] % 5 != 0 &
      arr1[count] % 6 != 0 & arr1[count] % 7 != 0 & arr1[count] % 8 != 0 & arr1[count] % 9 != 0 & arr1[count] != 1)
    {
        Console.WriteLine(arr1[count]);
    }
    count++;
}
