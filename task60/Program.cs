// Домашняя работа:
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


int ReadInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 9)
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

int[] GetSumRows(int[,] matr, int rows)
{   
    int[] newMatr = new int [rows]; 
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sumRows = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumRows = sumRows + matr[i,j];
        } 
        // Console.WriteLine (sumRows);
        newMatr[i] = sumRows;
    }
    return newMatr;       
}

void MinCountsRows(int[] newMatr)
{
    int min = newMatr[0];
    int k = 1; 
    for (int i = 1; i < newMatr.Length; i++)
    {
        if (newMatr[i] < min)
        {
           min = newMatr[i];
           k = i + 1;
        }
    }
    Console.WriteLine($"Минимальное значение {min} строки {k}");
}

// void PrintNewMatrix(int[] newMatr)
// {
// for (int i = 0; i < newMatr.Length; i++)
//     {
//         Console.Write(newMatr[i] + " ");  
//     }
// }

int rowsCount = ReadInt("Введите число строк:");
int columnsCount = ReadInt("Введите число столбцов:");
int [,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
Console.WriteLine();
int [] sum = GetSumRows(matrix, rowsCount);
// Console.WriteLine();
// PrintNewMatrix(sum); 
Console.WriteLine();
MinCountsRows(sum);