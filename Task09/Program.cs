﻿//выделить случайное число от 10 до 99, и из него найти большее число
// 2 способа выполнения
//1
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
if(firstDigit > secondDigit)
{
     Console.WriteLine($"Наибольшее цифра числа -> {firstDigit}");
}
else 
{
    Console.WriteLine($"Наибольшее цифра числа -> {secondDigit}");
}
//2
int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшее цифра числа -> {result}");
////
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшее цифра числа -> {maxDigit}");

int MaxDigit(int num)// num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10; 
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}
