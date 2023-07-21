// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double b1 = GetInput("Введите координату B1: ");
double k1 = GetInput("Введите координату К1: ");
double b2 = GetInput("Введите координату B2: ");
double k2 = GetInput("Введите координату K2: ");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых [{b1}, {k1}] и [{b2}, {k2}] ->  [{x}, { y}]");