﻿// на входе трех значное число,а на выходе показвает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if(number > 99 && number < 1000)
{
    int result = number % 10;
    Console.Write(result);
}
else
{
    Console.Write("Необходимо ввести трехзначное");
}