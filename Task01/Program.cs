// Является ли первое число квадратом второго числа
Console.WriteLine("Введите целое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число");
int numberB = Convert.ToInt32(Console.ReadLine());
int square = numberB * numberB;
if (square == numberA)
{
    Console.WriteLine(square);

}
else 
{
    Console.Write("нет");
}