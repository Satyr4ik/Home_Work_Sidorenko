// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int count = 0;
int[] arr = new int[8];

while(count < 8)
{
Console.Write($"Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
arr[count] = num;
count ++;
}
count = 0;
Console.Write("[");
while(count < 8)
{
Console.Write($"{arr[count]},");
count ++;
}
Console.Write("]");



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