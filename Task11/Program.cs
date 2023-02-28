// случайное трехзначное число и из него удалить вторую цифру и полуть двухзначное число из оставшихся чисел
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {number}");
//int firstDigit = number / 100;
//int lastDigit = number % 10;
//int result = firstDigit * 10 + lastDigit;
//Console.WriteLine($"Результат вычислений {result}");




int twoDigit = DigitSum(number);
Console.WriteLine($"Результат вычислений {twoDigit}");

int DigitSum(int num)// num = number
{
    int firstDigit = number / 100;
    int lastDigit = number % 10;
    int twoDigit = firstDigit * 10 + lastDigit;
    return twoDigit;
}