// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int count = 0;
for (int i = 0;; i++)
{
    Console.WriteLine($"Введите число {i+1}: \nдля прекращения ввода введите: stop");
    string str = Console.ReadLine();
    if (str=="stop")
    {
        break;   
    }
    int numbStr = Convert.ToInt32 (str);
    if (numbStr > 0)
    {
        count = count + 1;
    }
}
Console.WriteLine($"Введенно {count} положительных чисел (числа)");   