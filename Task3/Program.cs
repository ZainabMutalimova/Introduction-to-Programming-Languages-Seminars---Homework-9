﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (n == 0) return Ack(m - 1, 1);
        else return Ack(m - 1, Ack(m, n - 1));
    }
}

int m = Prompt("Ввведите первый параметр для функции Аккермана (число должно быть натуральным): ");
int n = Prompt("Ввведите второй параметр для функции Аккермана (число должно быть натуральным): ");
if (m < 0 || n < 0) Console.WriteLine("Введите натуральные числа .");
else Console.WriteLine($"Результат примения к числам функции Аккермана: {Ack(m, n)}.");