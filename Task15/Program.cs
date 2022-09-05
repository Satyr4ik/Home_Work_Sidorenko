// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


again:
Console.Write("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 7)
{
    if (num >= 6)
    {
        Console.WriteLine($"{num}, является выходным днем.");
    }
    else
    {
        Console.WriteLine($"{num}, не является выходным днем.");
    }
}
else
{
    Console.WriteLine("Введите цифру от 1 до 7.");
    goto again;
}

