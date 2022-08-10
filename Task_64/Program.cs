// // Задача 64: Задайте значения M и N. Напишите программу, которая выведет произведение натуральных чисел в промежутке от M до N.
// M = 1; N = 5. ->120
// M = 4; N = 6. -> 120


using System;
using static System.Console;

Clear();

WriteLine("Введите число M: ");
int m = int.Parse(ReadLine());
WriteLine("Введите стартовое число N: ");
int n = int.Parse(ReadLine());
int multiply = 1;
Write($"M = {m}; N = {n}. -> ");
PrinMultiply(m, n, multiply);

void PrinMultiply(int m, int n, int multi)
{
  multi = multi * n;
  if (n <= m)
  {
    Write($"{multi}");
    return;
  }
  PrinMultiply(m, n - 1, multi);
}

