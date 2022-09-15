// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int SumNum(int number)
{
    int num = 0;
    while(number > 0)
    {
        num = num + number % 10;
        number = number / 10;
    }
    return num;
}

Console.Write($"Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int sum = SumNum(num1);
Console.WriteLine($"Сумма цифр в числе: {sum}");