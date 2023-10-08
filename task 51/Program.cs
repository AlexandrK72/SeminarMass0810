// Задача 51: Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их 
// квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



int[,] CreatMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums]; // rows = 3, coiums = 4
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

int SumMatrix(int[,] matrix)
{
    int size = matrix.GetLength(1);
    if(matrix.GetLength(0) < matrix.GetLength(1))  size = matrix.GetLength(0);
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
      sum += matrix[i,i];

    }
    return sum;
}


// int SumMatrix(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += matrix[i, j];
//             }
//         }
       
//     } return sum;
// }


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // .GetLength(0) - функционал для определения количества строк 0 - 3 стороки

    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++) // .GetLength(0) - функционал для определения количества столбцов 0 - 4 столбца
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("  ]");
    }
}

int[,] matr = CreatMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matr);

int sumMatrix = SumMatrix(matr);
Console.WriteLine($"сумма элементов {sumMatrix}");

