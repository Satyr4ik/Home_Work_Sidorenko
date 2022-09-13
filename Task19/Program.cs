// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] number = new int[4];
int i = 0;
if (num > 9999 & num < 100000)
{
    while (num > 9999 & num < 100000)
    {
        if (num > 1000)
        {
            int kesh = num % 10;
            number[i] = kesh;
            num = num / 10;
            i++;
        }
        else if (num > 99)
        {
            num = num / 10;
        }
        else
        {
            int kesh = num % 10;
            number[i] = kesh;
            num = num / 10;
            i++;
        }
    }


    if (number[0] == number[3] & number[1] == number[2])
    {
        Console.WriteLine("Данное число являеться палиндромом.");
    }
    else
    {
        Console.WriteLine("Данное число не являеться палиндромом.");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число.");
}


