// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Natural (int n)
{
    if (n > 1) 
    {
        Console.Write($"{n}, ");
        return Natural(n-1);
    }
    else
    { 
        Console.Write("1");
        return 1;
    }
}

Console.Clear();
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Natural(n);