// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

again:
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 99 | num >= 1000)
{

    Console.WriteLine("Данное число не вляется трехзначным, введите трехзначное число.");
    goto again;
}
else
{

    num = (num / 10) % 10;
    Console.WriteLine(num);

}
