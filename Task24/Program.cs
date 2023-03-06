//1. принимаем число А
//2 выдает сумму чисел от 1 до А


Console.WriteLine(" Введите положительно целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");
int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum+= i;
    }
    return sum;
}


