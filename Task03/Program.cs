// присвоение день недели к числу
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
    if (number == 1)
{
    Console.WriteLine("Monday");
}
    if (number == 2)
{
    Console.WriteLine("Tuesday");
}
    if (number == 3)
{
    Console.WriteLine("Wednesday");
}
else 
    if (number > 3)
    {
        Console.WriteLine("Введите число не больше 3");
    }