// поиск max и min числа
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.Write("max число ");
    Console.WriteLine(numberA);
    Console.Write("min число ");
    Console.WriteLine(numberB);
}

else
{
    Console.Write("max число ");
    Console.WriteLine(numberB);
    Console.Write("min число ");
    Console.WriteLine(numberA);
}
