// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] kub = new int[num];
int i = 0;

while (i <= (num - 1))
{
    kub[i] = i + 1;
    i++;
}
i = 0;
Console.Write($"{num} -> ");
while (i <=(num - 1))
{
    int result = Convert.ToInt32(Math.Pow(kub[i], 3));
    Console.Write($" {result}, ");
    i++;
}