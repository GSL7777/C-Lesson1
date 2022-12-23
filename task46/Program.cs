// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэфициент k1 первой прямой:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэфициент k2 второй прямой:");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэфициент b1 первой прямой:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэфициент b2 второй прямой:");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1==k2&&b1==b2)
{
    Console.WriteLine("Прямые совпадают");   
}
    else if (k1==k2)
    {
        Console.WriteLine("Прямые параллельные");   
    } 
        else
        {   
            double x = (b2-b1)/(k1-k2);
            double y = (k1*b2 - k2*b1)/(k1-k2);
            // Console.WriteLine($"Прямые пересекаются в точке ({x},{y})");
            Console.WriteLine($"Прямые пересекаются в точке ({x.ToString("F"+1)},{y.ToString("F"+1)})");
        }