/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


Console.Write("Введите число, для получения суммы его цифр: ");
string preNumber = Console.ReadLine();
int number = 0;
for(int i = 0; i < preNumber.Length; i++)
{
  
 number = number +  int.Parse(Convert.ToString(preNumber[i]));
}
Console.WriteLine("\nСумма цифр числа " + preNumber + " равна: " + number);
