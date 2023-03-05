/// Напишите программу, которая принимает на вход трёхзначное число 
/// и на выходе показывает вторую цифру этого числа.

//456 -> 5
///782 -> 8

int threeDigitNumber = new Random().Next(100, 1000);
Console.WriteLine($"Случайное  трехзначное число {threeDigitNumber}");
int secondDigit = threeDigitNumber / 10;
int oneDigit = secondDigit % 10;
Console.WriteLine($"Результат вычислений {secondDigit}");
Console.WriteLine($"Результат вычислений {oneDigit}");


int numberThree = inNumber(threeDigitNumber);
Console.WriteLine($"Результат {numberThree}");

int inNumber(int num)
{
    int secondDigit = num / 10;
    int oneDigit = secondDigit % 10;
    return oneDigit;
}