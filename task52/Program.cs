// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2​
// 5 9 2 3
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет


int ReadInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 100)
{
    int[,] matr = new int[rows, columns];
    
    var rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }   
    }
    return matr;
}


int NumbMatrix(int[,] matr)
{   
    int numb = -100;
    int positRows = ReadInt("Введите номер строки:");
    int positColumns = ReadInt("Введите номер столбца:");
    if (positRows >= matr.GetLength(0)||positColumns >= matr.GetLength(1))
    {
        Console.WriteLine("Такой позиции в массиве не существует");
    }
    else for (int i = 0 ; i <= positRows; i++) 
    {   
        for (int j = 0; j <= positColumns; j++)
        {
            numb = matr[i, j]; 
        } 
    }
    return numb;     
}

void PrintMatrix(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine(); 
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }  
    }
}

int rowsCount = ReadInt("Введите число строк:");
int columnsCount = ReadInt("Введите число столбцов:");
int [,] matrix = GetRandomMatrix(rowsCount , columnsCount);
PrintMatrix(matrix);
Console.WriteLine();
int numb = NumbMatrix(matrix);
Console.WriteLine($"Значение элемента в массиве: {numb}");