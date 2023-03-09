﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите натуральное число ");
int Number = Convert.ToInt32(Console.ReadLine());

CubeNumber(Number);
void CubeNumber(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i} -> {Math.Pow(i, 3)}"); 
        i++;
    }
}

CubeNumber(Number);