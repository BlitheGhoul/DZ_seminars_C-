/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
void someCubes(int number1)
{
    int i = 0;
    while(i <= number1)
    {
        int number2 = (i * i) * i;
        Console.Write("Куб числа " + i + ":" + " ");
        Console.WriteLine(number2 );
        Console.WriteLine();
        i++;
    }
}

Console.Write("Введите число: ");
int numForCube = int.Parse(Console.ReadLine());
Console.WriteLine("Таблица кубов до Вашего числа:");
someCubes(numForCube);