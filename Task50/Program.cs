// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

int PrintPosition(int[,] matrix)
{
    Console.WriteLine("Введите значение позиции элемента: m и n");
    Console.Write("Строка: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столбец: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    if (matrix.GetLength(0) > m & matrix.GetLength(1) > n) 
    {
        result = matrix[m, n];
        Console.Write($" {result} ");
    }
    else Console.WriteLine("Данной позиции в масиве не существует.");
    return result;
}

int[,] arr = CreateMatrixRndInt(4, 4, 1, 100);
PrintMatrix(arr);
Console.WriteLine("_________________________________________________________");
PrintPosition(arr);
