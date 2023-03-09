///Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
///14212 -> нет
//12821 -> да
///23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if ( Number > 10000)
{
    bool fivenumber = FiveNumber(Number);
    Console.WriteLine(fivenumber ? "да" : "нет");
}
else
{
    Console.WriteLine("Это число не пятизначное ");
}


bool FiveNumber(int num)
{
    return num == num % 10 * 10000 + (num / 10) % 10 * 1000 + (num / 100) % 10 * 100 + (num / 1000) % 10 * 10 + num / 10000;  
}
