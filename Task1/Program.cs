// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int NaturalNumber(int n)
{
  if (n != 1)
  {
    Console.Write(n + ", ");
    NaturalNumber(--n);
  }
  return 1;
}

int n = Prompt("Ввведите число N: ");
if (n < 1)
{
  Console.WriteLine("Введите положительное число!");
  return;
}
Console.WriteLine(NaturalNumber(n));