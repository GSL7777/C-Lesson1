// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());
int numberMax = number1;
if (numberMax < number2)
{
    numberMax = number2;
}
if (numberMax < number3)
{
    numberMax = number3;
}
Console.WriteLine("Максимальное значение из трех чисел:");   
Console.WriteLine(numberMax);