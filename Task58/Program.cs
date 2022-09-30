// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],6}, ");
            else Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine("]");
    }
}

int[,] MultipMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix2.GetLength(0), matrix1.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                for (int r = 0; r < matrix1.GetLength(1); r++)
                {
                    matrix[i, j] = matrix1[i, r] * matrix2[r, j] + matrix[i, j];
                }
            }
        }
    }
    return matrix;
}

int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(matrix1);
Console.WriteLine("____________________________________________");
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(matrix2);
Console.WriteLine("____________________________________________");
int[,] multiplay = MultipMatrix(matrix1,matrix2);
PrintMatrix(multiplay);