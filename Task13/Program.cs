// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num >= 1000)
{
    num = num / 10;

}
if (num > 99 && num <= 999)
{
    num = num % 10;
    Console.WriteLine($"Ответ: {num}");
}
else
{
    Console.WriteLine("У данного числа нет третьей цифры.");
}
