// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

PrintSumm(m, n, 0);

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {summ}");
        return;
    }
    PrintSumm(m, n - 1, summ);
}
