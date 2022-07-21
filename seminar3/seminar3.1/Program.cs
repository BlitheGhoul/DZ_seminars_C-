/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/* Вариант 1: 
Console.Write("Введите пятизначное число, для проверки на палиндром: ");
string num1 = Console.ReadLine();
char[] myReverse = num1.ToCharArray();
Array.Reverse(myReverse);
string num2 = new string(myReverse);
int num3 = int.Parse(num1);
int num4 = int.Parse(num2);
if(num3 > num4 || num4 > num3)
{
Console.WriteLine("Вы ввели НЕ палиндром!");
}
else
{
Console.WriteLine("Вы ввели палиндром!");
}
*/

//Вариант 2:
Console.Write("Введите пятизначное число, для проверки на палиндром: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = num1 % 10;
if (num2 == num1 / 10000)
{
    num2 = (num1 % 100) / 10;
    if (num2 == (num1 / 1000) % 10)
    {
    Console.WriteLine("Да, это палиндром!");
    } 
    else  Console.WriteLine("Нет, это не палендром!");   
}
else  Console.WriteLine("Нет, это не палиндром!");
