// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 > 9999 && number1 < 100000)
{
    int num1 = number1 / 10000 % 10;
    int num2 = number1 / 1000 % 10;
    int num3 = number1 / 100 % 10;
    int num4 = number1 / 10 % 10;
    int num5 = number1 % 10;
    int number2 = num5 * 10000 + num4 * 1000 + num3 * 100 + num2 * 10 +num1;
        if (number1 == number2)
        {
            Console.WriteLine("Число является палиндромом");    
        } 
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }   
}
else
{
    Console.WriteLine("Введите правильное число!!!");
}
