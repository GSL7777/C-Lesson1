// Домашняя работа:
// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int ReadInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns)
{
  int[,] matr = new int[rows, columns];
  int n = rows;
  int m = columns;

  int row = 0;
  int col = 0;
  int dx = 1;
  int dy = 0;
  int dirChanges = 0;
  int visits = m;

  for (int i = 0; i < matr.Length; i++) 
  {
    matr[row, col] = i + 1;
    if (--visits == 0)
    {
      visits = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
      int temp = dx;
      dx = -dy;
      dy = temp;
      dirChanges++;
    } 
    
    col += dx;
    row += dy;
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

int rowsCount = ReadInt("Введите число строк:");
int columnsCount = ReadInt("Введите число столбцов:");
int [,] matrix = GetRandomMatrix(rowsCount,columnsCount);
PrintMatrix(matrix);
Console.WriteLine();