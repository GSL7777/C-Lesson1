// Домашняя работа:
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

int[,] GetSortMinMaxMatr(int[,] matr)
{   
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(1); k++) 
        {
            int min = matr[i, k];
            for (int j = 1+k; j < matr.GetLength(1); j++)
            {
                if (matr[i,j] < min)
                {
                int temp = matr[i,j];
                matr[i,k] = matr[i,j];
                matr[i,j] = min;
                min = temp; 
                }
            } 
        }
    }
    return matr;
}

int rowsCount = ReadInt("Введите число строк:");
int columnsCount = ReadInt("Введите число столбцов:");
int [,] matrix = GetRandomMatrix(rowsCount,columnsCount);
PrintMatrix(matrix);
Console.WriteLine();
int [,] newMatrix = GetSortMinMaxMatr(matrix); 
Console.WriteLine();
PrintMatrix(newMatrix);