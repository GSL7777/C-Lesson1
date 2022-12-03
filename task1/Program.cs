Console.WriteLine("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
int number_3 = number_2 * number_2;
//Console.WriteLine(number_3);
if (number_1 == number_3)
{
     Console.WriteLine("Yes");   
}
else
{
     Console.WriteLine("No");
}