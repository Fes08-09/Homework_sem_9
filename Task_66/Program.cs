// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using System;
using static System.Console;

Clear();

WriteLine("Введите число M: ");
int m = int.Parse(ReadLine());
WriteLine("Введите стартовое число N: ");
int n = int.Parse(ReadLine());
int sum = 0;
Write($"M = {m}; N = {n}. -> ");

PrinSum(m, n, sum);

void PrinSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Write($"{sum}");
    return;
  }
  PrinSum(m, n - 1, sum);
}
