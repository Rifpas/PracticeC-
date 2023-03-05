Console.WriteLine("Введите номер четверти");
Console.Write("Четверть: ");
int number = Convert.ToInt32(Console.ReadLine());


int cord = Cord(number);

Console.WriteLine(cord);

string Cord(int num)
{
    if (num == 1) return "x > 0 && y > 0)";          i
    if (num == 2) return "x < 0 && y > 0";
    if (num == 3) return "x < 0 && y < 0";
    if (num == 4) return "x > 0 && y < 0";
    return "Введена некорректная информация";
    
}