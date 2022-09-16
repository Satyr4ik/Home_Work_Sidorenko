// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int[] CreateArrayRndInt(int size)
{
int count = 0;
int[] array = new int[size];

while(count < size)
{
Console.Write($"Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
array[count] = num;
count ++;
}
 return array;
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

int[] arr = CreateArrayRndInt(8);
PrintArray(arr);
