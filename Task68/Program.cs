// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int Akkerman = Akk(m, n);

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akk(m - 1, 1);
    else return Akk(m - 1, Akk(m, n - 1));
}

Console.Write($"Функция Аккермана = {Akkerman} ");