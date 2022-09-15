// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int ExponNumber(int basis, int index)
{
    int count = 1;
    int num = basis;
    while(count < index)
    {
        num = num * basis;
        count ++;
    }
    return num;
}

Console.Write($"Введите число которое хотите возвести в степень: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите в какую степень хотите возвести число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = ExponNumber(num1,num2);

Console.WriteLine($"{num1}^{num2}={num3}");