// Домашняя работа
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число диапазона чисел:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число диапазона чисел:");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumb (int min, int max)
{
if (min > max) return -1;
if (min == max) return max;
min = min + SumNumb (min+1, max); 
return min; 
}
Console.WriteLine();
Console.WriteLine(SumNumb (M,N));
