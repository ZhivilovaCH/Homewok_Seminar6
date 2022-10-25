// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите число b1:");
double b1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите число k1:");
double k1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите число b2:");
double b2 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите число k2:");
double k2 = Convert.ToDouble(Console.ReadLine()!);

void GetString()
{
    Console.WriteLine($"b1: {b1}, " + $"k1: {k1}, "  + $"b2: {b2}, " + $"k2: {k2} ");
    Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");
}


double GetX()
{

    double x = (b2 - b1) / (k1 - k2);

    if (b1 == b2)
    {
        Console.WriteLine("Прямые не пересекаются (прямые параллельны).");
    }
    if (b1 != b2)
    {
        Console.WriteLine("Прямые пересекаются в точке.");
    }

    return x;
}

GetString();
double x = Math.Round(GetX(), 2);

double GetY()
{

    double y = k1 * x + b1;

    return y;
}

double y = Math.Round(GetY(), 2);

Console.WriteLine("x " + x + " y " + y);
