// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,]CreatMatrixInt(int m, int n)
{
    int [,] matrix = new int[m, n]; // rows = 3, coiums = 4
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i+j;
        }
        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{ 
    for (int i = 0; i < matrix.GetLength(0); i++) // .GetLength(0) - функционал для определения количества строк 0 - 3 стороки

    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++) // .GetLength(0) - функционал для определения количества столбцов 0 - 4 столбца
        {
            Console.Write($"{matrix[i, j], 5}");
        }
       Console.WriteLine("  ]"); 
    }
}
int[,] matr = CreatMatrixInt(100, 100);
PrintMatrix(matr);