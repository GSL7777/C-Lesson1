// Домашняя работа
// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int min = 1;

int LineNumbers(int min, int max)
{
    if(max <= 0) return -1;
    if(min < max) 
    Console.Write(LineNumbers(min+1, max));
    return min;   
}
Console.WriteLine (LineNumbers(min, N));