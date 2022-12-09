Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Monday");
}
else if (number == 2)
{
    Console.WriteLine("Tuesday");
}
else if (number == 3)
{
    Console.WriteLine("Wednesday");
}
else if (number == 4)
{
Console.WriteLine("Thursday");
}
else if (number == 5)
{
Console.WriteLine("Friday");
}
else if (number == 6)
{
Console.WriteLine("Saturday");
}
else if (number == 7)
{
Console.WriteLine("Sunday");
}
else
{
Console.WriteLine("Введите правильное значение!!!");
}
// if (number > 7 || number < 7) //альтернативная запись, чтоб избавиться от команды  "else" в строках 7, 11, 15, 19, 23, 27 и 31
// {
// Console.WriteLine("Введите правильное значение!!!");   
// }