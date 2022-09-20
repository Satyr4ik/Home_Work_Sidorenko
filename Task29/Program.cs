// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] ArrayMylt(int[] array)
{
    int size = array.Length/2;
    if(array.Length%2 == 1) size += 1;
    int[] arraymylt = new int[size];
    for (int i = 0; i < size; i++)
    {   
        arraymylt[i] = array[i] * array[array.Length-i-1];
    }
    return arraymylt;
}
void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int[] arr = CreateArrayRndInt(4, 1, 10);
int[] result = ArrayMylt(arr);

PrintArray(arr);
Console.Write("->");
PrintArray(result);