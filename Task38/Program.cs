// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max) + Math.Round(rnd.NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double DiffMaxMin(double[] array)
{
    double max = array[1];
    double min = array[1];
    double diff = 0.0;
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    diff = max - min;
    return diff;
}

Console.Clear();
double[] arr = CreateArrayRndInt(4, 1, 10);
PrintArray(arr);
double difference = DiffMaxMin(arr);
Console.WriteLine($"->{Math.Round(difference, 2)}");