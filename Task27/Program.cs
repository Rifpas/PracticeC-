//  Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine(" Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());


if(number > 0)
{
    int sumNumbers = SumNumbers(number);
    Console.WriteLine($" Число {number} = {sumNumbers} сумма цифр");
}
else
{
    Console.WriteLine(" Введите положительное число!!! ");
}

int SumNumbers(int num)
{
    int count = 0;
    while (num > 0)
    {
        count +=num % 10;
        num = num / 10;
    
    }
    return count;
}