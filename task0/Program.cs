Console.WriteLine("Введите число: ");
// String answer = Console.ReadLine(); //Сдесь вводиться строка данных. Например:  "528"
// int number = Convert.ToInt32(answer); //Сдесь конвертируется строка данных."528" в значения 5, 2 и 8 
int number = Convert.ToInt32(Console.ReadLine()); //вместо двух комманд (2 и 3) можно воспользоваться одной(4)
Console.WriteLine(number * number);