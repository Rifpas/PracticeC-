// принимает на вход число N и выдает произведение чисел от 1 до N
 // 4-> 24
 // 5 -> 120


Console.WriteLine(" Введите положительно целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
    int factNumbers = FactorialNumbers(number);
    Console.WriteLine($" произведение чисел = {factNumbers}");
}

else 
{
    Console.WriteLine(" Введите положительно целое число ");
}

int FactorialNumbers(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        checked  // не дает возможности пользователю получить не правильный результат при не верных вводных данных. проверка на переполнение типа данных
        {
            fact *= i;
        }
    }
    return fact;
}
