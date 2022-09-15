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