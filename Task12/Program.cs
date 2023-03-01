// на входе два числа и выводить, является ли первое числократным второму
// если число 1 не кратно числу 2, товывод остаток от деления.
// 34, 5 -> не кратно, остаток 4

Console.WriteLine("Введите число 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());
int total = num1 % num2;
if (num1 % num2 == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine($"Не кратно, остаток {total}");
}

//int result = num1 % num2 == 0 ? 0 : total;
//Console.WriteLine($"остаток {result}");

int oneNum(int num1, int num2);
Console.WriteLine($"Результат вычислений {oneNum}");
{

    return num1 % num2;
}
