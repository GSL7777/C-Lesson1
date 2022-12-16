// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int GetCountToNumber(int number)
{
    int count = 0;
    while (number != 0)
    {
    count = count + Math.Abs(number % 10);
    number = number / 10;
    }
    return count;
}
int N = ReadInt("Введите число: ");
int result = GetCountToNumber(N);
Console.WriteLine($"Сумма цифр в числе {N} = {result}");