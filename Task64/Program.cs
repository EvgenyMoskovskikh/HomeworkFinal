// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от n до 1. Выполнить с помощью рекурсии.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

void numbers(int n)
{
    if (n > 0)
    {
    Console.Write($"{n} ");
    numbers(n - 1);
    }
}
numbers(n);
