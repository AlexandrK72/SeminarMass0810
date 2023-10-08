int[,]CreatMatrixRndInt(int rows, int colums, int min, int max)
{
    int [,] matrix = new int[rows, colums]; // rows = 3, coiums = 4
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max +1);
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

int[,] matr = CreatMatrixRndInt(3, 4, -100, 100);
PrintMatrix(matr);
