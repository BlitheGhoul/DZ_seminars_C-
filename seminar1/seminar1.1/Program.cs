/* Задача 2:
Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
*/

Console.Write("Введите первое число, для сравнения: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число, для сравнения: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Наибольшее число: " + num1);
}
else if (num1 == num2)
{
    Console.WriteLine("Ошибка! Перезапустите программу и введите разные числа!");
}
else
{
    Console.WriteLine("Наибольшее число: " + num2);
}