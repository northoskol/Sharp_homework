﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите первое число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Большее число: " + Math.Max(number1, number2));
Console.Write(" Меньшее число: " + Math.Min(number1, number2));