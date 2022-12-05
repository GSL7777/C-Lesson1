// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Введено не верное значение. Введите целое число");
}
else
{
    int mod = number % 2;
    Console.WriteLine(mod);

if (mod == 1)
{
    Console.WriteLine("Число нечетное");
}
else
{
    Console.WriteLine("Число четное");
}
}
