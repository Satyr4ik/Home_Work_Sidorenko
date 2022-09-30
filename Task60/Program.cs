// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixСubeRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] сube = new int[rows, columns, depth];

    Random rnd = new Random();
    for (int i = 0; i < сube.GetLength(0); i++)
    {
        for (int j = 0; j < сube.GetLength(1); j++)
        {
            for (int z = 0; z < сube.GetLength(2); z++)
            {
                сube[i, j, z] = rnd.Next(min, max);
            }
        }
    }
    return сube;
}

void PrintMatrixCube(int[,,] сube)
{

    for (int i = 0; i < сube.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < сube.GetLength(1); j++)
        {
            for (int z = 0; z < сube.GetLength(2); z++)
            {
                if (z < сube.GetLength(2) - 1) Console.Write($"{сube[i, j, z],6} ({i} {j} {z}), ");
                else Console.Write($"{сube[i, j, z],6} ({i} {j} {z})");
            }
        }
        Console.WriteLine("]");
    }

}
Console.Clear();
int[,,] cub = CreateMatrixСubeRndInt(2, 2, 2, 1, 100);
PrintMatrixCube(cub);