﻿// Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли оно на
// два без остатка).
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число N = ");
int N = int.Parse(Console.ReadLine());


if (N % 2==1)
{
    Console.WriteLine("число нечетное");
}
else
{
    Console.WriteLine("Число четное");
}