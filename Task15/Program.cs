///запишите программу, которая принимает на вход цифру, 
///обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
///1 -> нет
Console.WriteLine($"Введите номер дня недели");
int num1 = Convert.ToInt32(Console.ReadLine());

bool hollyD = hollydays(num1);
Console.WriteLine(hollyD ? "да" : "нет"); 

bool hollydays(int num)
{
    return(num > 5);
}
