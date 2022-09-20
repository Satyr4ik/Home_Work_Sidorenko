// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersection(double k1, double b1, double k2, double b2)
{
    double intersX = 0.0;
    double intersY = 0.0;
    intersX = (b2 - b1) / (k1 - k2);
    intersY = k2 * intersX + b2;
    Console.Write($"Пересечение двух прямых: ({intersX}:{intersY})");
}

Console.Clear();
Console.WriteLine("Нахождения пересечения двух прямых, заданных уравнениями:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
Console.Write($"Введите значение k1: ");
double coefficient1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите значение b1: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите значение k2: ");
double coefficient2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите значение b2: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Intersection(coefficient1, num1, coefficient2, num2);