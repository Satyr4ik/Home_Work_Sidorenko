// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Natural (int begin, int end)
{
    int sum =0;
    Console.WriteLine($"{begin} {end}");
    while (begin <= end)
    {
        if (begin >= 1) 
        {
            sum = sum + begin;
            begin++;
        }
        else begin++;
    }

    return sum;
}

Console.Clear();


Console.Write("Введите начало промежутка: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец промежутка: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa = Natural (m,n);

Console.WriteLine($"Сумма натуральных чисел равна: {summa}");
