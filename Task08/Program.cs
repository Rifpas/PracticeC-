/// четные числа от 1 до N
Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    for (int i = 2; i <= number; i+=2)
    {
        Console.Write(i + " ");
    }
}
else
{
    Console.Write("Число должно быть положительным");
}