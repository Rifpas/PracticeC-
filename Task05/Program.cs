//принимает на входе число N, а на выходе выводит все целые числа от -N до N

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    for (int i = -number; i <= number; i++)
    {
        Console.Write(i + " ");
    }
}
else
{
    Console.Write("Число должно быть положительным");
}