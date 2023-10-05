// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumOfNaturalNumbers(int m, int n)
{
    if (m != n) return SumOfNaturalNumbers(m+1, n) + m;
    else return m;
}

int m = Prompt("Ввведите нижнюю границу предела: ");
int n = Prompt("Ввведите верхнюю границу предела: ");
Console.WriteLine($"Сумма натуральных чисел предела: {SumOfNaturalNumbers(m, n)}.");