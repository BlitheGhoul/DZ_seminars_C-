/* 
Напишите программу для вычисления площади круга, прямоугольника и треугольника. 
Ввод данных осуществляется в диалоговом режиме. 
На первом шаге у пользователя запрашивается фигура, площадь которой нужно вычислить.
На втором шаге пользователь вводит параметры, необходимые для рассчета. Затем, выводится результат.
*/

Console.WriteLine("Эта программа находит площадь выбранной Вами фигуры.\n Для выбора фигуры укажите число: \n 1 - если хотите выбрать КРУГ, \n 2 - если хотите выбрать ПРЯМОУГОЛЬНИК, \n 3 - если хотите выбрать ТРЕУГОЛЬНИК.");
Console.WriteLine();
Console.Write("Введите номер Вашей фигуры: ");
int figure = int.Parse(Console.ReadLine());
string errorZero = "Ошибка, введён ноль! Перезапустите программу.";
string errorWrongNumber = "Ошибка, введён некорректный номер! Перезапустите программу.";
if(figure == 1)
{
    Console.WriteLine("Ваша фигура - КРУГ");
    Console.WriteLine();
    Console.WriteLine("Укажите число: \n 1 - если Вам известен радиус Вашего КРУГА(см), \n 2 - если Вам известен диаметр Вашего КРУГА(см), \n 3 - если Вам известна длинна окружности Вашего КРУГА(м)");
    Console.WriteLine();
    Console.Write("Введите номер известного Вам параметра: ");
    double areaOfCircle = 0;
    int parameter = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if(parameter == 1)
    {
        Console.Write("Введите известный Вам радиус: ");
        double radOfCircle = double.Parse(Console.ReadLine());
        if(radOfCircle != 0)
        {
            
            Console.WriteLine();
            areaOfCircle = Math.Round(Math.Pow(radOfCircle, 2) * Math.PI, 2);
            Console.WriteLine("Площадь Вашего КРУГА примерно равна: " + areaOfCircle + " кв.см");
        }

        else Console.WriteLine(errorZero);
    }

    else if (parameter == 2)
    {
        Console.Write("Введите известный Вам диаметр: ");
        double diamOfCircle = double.Parse(Console.ReadLine());
        if(diamOfCircle != 0)
        {
            Console.WriteLine();
            areaOfCircle = Math.Round(Math.Pow(diamOfCircle, 2) * (Math.PI / 4), 2);
            Console.WriteLine("Площадь Вашего КРУГА примерно равна: " + areaOfCircle + " кв.см");
        }

        else Console.WriteLine(errorZero);
    }

    else if (parameter == 3)
    {
        Console.Write("Введите известную Вам длинну окружности: ");
        double circumference = double.Parse(Console.ReadLine());
        if(circumference != 0)
        {
            Console.WriteLine();
            double radOfCircle = circumference / (Math.PI * 2);
            areaOfCircle = Math.Round(Math.Pow(radOfCircle, 2) * Math.PI, 3);
            Console.WriteLine("Площадь Вашего КРУГА примерно равна: " + areaOfCircle + " кв.м");
        }

        else Console.WriteLine(errorZero);
    }
    else Console.WriteLine(errorWrongNumber);
    
}
else if(figure == 2)
{
Console.WriteLine();
Console.WriteLine("Ваша фигура - ПРЯМОУГОЛЬНИК");
Console.WriteLine();
Console.Write("Введите длинну Вашего ПРЯМОУГОЛЬНИКА(см): ");
double rectangleLong = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите ширину Вашего ПРЯМОУГОЛЬНИКА(см): ");
double rectangWidth = double.Parse(Console.ReadLine());
Console.WriteLine();
if(rectangleLong == 0 || rectangWidth == 0) Console.WriteLine(errorZero);
else Console.WriteLine("Площадь Вашего ПРЯМОУГОЛЬНИКА равна: " + (rectangleLong * rectangWidth) + " кв.см");
}
else if (figure == 3)
{
    Console.WriteLine();
    Console.WriteLine("Ваша фигура - ТРЕУГОЛЬНИК");
    Console.WriteLine();
    Console.Write("Выберите имеющиеся у Вас данные и введите число: \n 1 - если известны три стороны, \n 2 - если известны две стороны и угол между ними, \n 3 - если известна одна сторона и опущенная на неё высота.");
    int knowInformation = int.Parse(Console.ReadLine());
    if (knowInformation == 1)
    { 
        Console.WriteLine();
        Console.WriteLine("Введите длинну первой стороны (см)");
        double firstSide = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Введите длинну второй стороны (см)");
        double secondSide = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Введите длинну третьей стороны (см)");
        double thirdSide = double.Parse(Console.ReadLine());
        double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
        Console.WriteLine();
        if(firstSide == 0 || secondSide == 0 || thirdSide == 0 ) Console.WriteLine(errorZero);
        else Console.WriteLine("Площадь Вашего ТРЕУГОЛЬНИКА равна: " + Math.Round(Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide)), 2) + " кв.см");
    }
    else if(knowInformation == 2)
    {
     Console.WriteLine();
     Console.WriteLine("Введите длинну первой известной стороны: ");
     double firstSide = double.Parse(Console.ReadLine());
     Console.WriteLine();
     Console.WriteLine("Введите длинну второй известной стороны: ");
     double secondSide = double.Parse(Console.ReadLine());
     Console.WriteLine();
     Console.WriteLine("Введите градус угла между известными сторонами: ");
     double angle = double.Parse(Console.ReadLine());
     Console.WriteLine();
      if(firstSide == 0 || secondSide == 0 || angle == 0 ) Console.WriteLine(errorZero);
      else Console.WriteLine("Площадь Вашего ТРЕУГОЛЬНИКА равна: " + Math.Round(0.5 * firstSide * secondSide * Math.Sin(angle * Math.PI/180), 2) + " кв.м");
    }
    else if (knowInformation == 3)
    {
        Console.WriteLine();
        Console.Write("Введите высоту ТРЕУГОЛЬНИКА: ");
        double triangleHeight = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введите основание ТРЕУГОЛЬНИКА: ");
        double triangleBase = double.Parse(Console.ReadLine());
         if(triangleHeight == 0 || triangleBase == 0) Console.WriteLine(errorZero);
         else Console.WriteLine("Площадь Вашего ТРЕУГОЛЬНИКА равна: " + Math.Round(0.5 * triangleBase * triangleHeight, 2) + " кв.cм");
    
    }
}
   else Console.WriteLine(errorWrongNumber);