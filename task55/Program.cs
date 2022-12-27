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

int[] GetSumColumns(int[,] matr)
{
//   int[] summ = new int [matr.GetLength(1)];
    for (int j = 0, k = 0; j < matr.GetLength(1); j++) 
    {
        int summa = 0;
        for (int i = 0; i < matr.GetLength(0);i++)     
            {
                summa += matr[i,j];
            }
                summ[k] = summa/matr.GetLength(1);
                Console.WriteLine("Среднее арифметическое столбца "+(j+1)+" равно: "+summ[k]);
                k++;
    } 
}

     



// {
//     int[] summ = new int [matr.GetLength(1)];
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             summ[j] += matr[i, j];
//         }
//     return summ;
//     }
// } 



// {
//     int sum = 0;
//     int j = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             sum += matr[i, j];
//         }
//     int aver = sum/matr.GetLength(0);
//     return aver;
// }      


int rowsCount = ReadInt("Введите число строк:");
int columnsCount = ReadInt("Введите число столбцов:");
int [,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
int[] summ = GetSumColumns(matrix);
Console.WriteLine();
Console.WriteLine(summ);
