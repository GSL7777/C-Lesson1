// Задача 38: 
// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int [] array = new int [5];
for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(1, 100);   
}
int max = array [0];
for (int j = 0; j < array.Length; j++)
{
    if (array [j] > max)
    {
     max = array[j];   
    }
}
int min = array [0];
for (int j = 0; j < array.Length; j++)
{
    if (array [j] < min)
    {
     min = array[j];   
    }
}
int diff = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива:\n [{string.Join(", ", array)}] \nсоставляет: {diff}");

