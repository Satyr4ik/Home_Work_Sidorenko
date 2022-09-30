// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] CreateMatrixRndInt(int rows, int columns)
// {
//     int meaning = 1;
//     int[,] matrix = new int[rows, columns];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = meaning++;
//         }
//     }
//     return matrix;
// }

void PrintMatrix(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i++)
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

int[,] Spire(int rows, int columns)
{
    int currentChar = 1;
    int[,] matrix = new int[rows, columns];
    for (int padding = 0; padding < matrix.GetLength(1) / 2; padding++)
    {
        for (int j = padding; j < matrix.GetLength(1) - padding; j++)
            matrix[padding, j] = currentChar;
        for (int j = padding; j < matrix.GetLength(1) - padding; j++)
            matrix[matrix.GetLength(1) - padding - 1, j] = currentChar;
        for (int i = padding + 2; i < matrix.GetLength(1) - padding - 1; i++)
            matrix[i, padding] = currentChar;
        for (int i = padding + 1; i < matrix.GetLength(1) - padding - 1; i++)
            matrix[i, matrix.GetLength(1) - padding - 1] = currentChar;
        currentChar = 1 - currentChar;
        matrix[padding + 1, padding] = currentChar;
    }
    if (matrix.GetLength(1) % 2 != 0 && matrix[0, 0] == 1) matrix[matrix.GetLength(1) / 2, matrix.GetLength(1) / 2] = 1;
    return matrix;
}
Console.Clear();
int[,] matrix = Spire(4, 4);
PrintMatrix(matrix);
