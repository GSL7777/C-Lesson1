// Домашняя работа:
// Задача 60. Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] GetRandomMatrix()
{
    int[,,] matr = new int[2, 2, 2];
    var rand = new Random();
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                matr[i, j, k] = rand.Next(10, 100);   
            }   
        }
    }
    return matr;
}

void PrintMatrix(int[,,] matr)
{
for (int i = 0; i < 2; i++)
    { 
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine($"{matr[i, j, k]} [{i}, {j}, {k}]"); 
            }  
        }
    }
}

int [,,] matrix = GetRandomMatrix();
PrintMatrix(matrix); 