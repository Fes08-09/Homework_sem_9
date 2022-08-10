// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


using System;
using static System.Console;

Clear();

WriteLine("Введите число m: ");
int m = int.Parse(ReadLine());
WriteLine("Введите стартовое число n: ");
int n = int.Parse(ReadLine());

int functionAkk = FunctionAkkerman(m, n);

Write($"m = {m}, n = {n} -> A(m,n) = {functionAkk}");

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return FunctionAkkerman(m - 1, 1);
        }
        else 
        {
            return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
        }
    }
}

