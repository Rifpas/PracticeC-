///принимает одно число и проверяет кратно ли оно одновременно 7 и 23
/// 14 на вход  два числа и проверяет, является ли одно число квадратом другого

Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
/// булевый метод
bool toBeOrNot = ToBeOrNot(num1);
Console.WriteLine(toBeOrNot ? "да" : "нет"); // тернарный оператор лиибо (toBeOrNot == true : no)

bool ToBeOrNot(int num1)
{
    return num1 % 7 == 00 && num1 % 23 == 0; // 
}