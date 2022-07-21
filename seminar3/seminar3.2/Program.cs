Console.Write("Введите координату X первой точки: ");
double x1 = double.Parse(Console.ReadLine()); 

Console.Write("Введите координату Y первой точки: ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Введите координату Z первой точки: ");
double z1 = double.Parse(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Введите координату Y второй точки: ");
double y2 = double.Parse(Console.ReadLine());

Console.Write("Введите координату Z второй точки: ");
double z2 = double.Parse(Console.ReadLine());

double coordinates = 0.0;

coordinates = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
coordinates = Math.Round(coordinates, 2);

Console.WriteLine(coordinates);