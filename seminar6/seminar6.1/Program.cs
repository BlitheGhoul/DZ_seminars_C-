/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
void PrintArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
}

Console.Write("Сколько чисел Вы планируете ввести? \nВаш ответ: ");
int[] arrNum = new int [int.Parse(Console.ReadLine())];
int sum = 0;
for(int index = 0; index < arrNum.Length; index ++)
{
    Console.WriteLine("Введите число: ");
    arrNum[index] = int.Parse(Console.ReadLine());
    if(arrNum[index] > 0) 
    {
        sum += arrNum[index];
    }
    
}
Console.Write("Введённые Вами числа:  ");
PrintArray(arrNum);

Console.WriteLine("\nСумма чисел, которые были больше нуля: " + sum);