// является ли вводимое число четным
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;
if (result == 0)
{
    Console.Write("Четное число");
}

else
{
    Console.Write("Не четное число");
}
