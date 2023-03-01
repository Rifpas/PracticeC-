// на вход  два числа и проверяет, является ли одно число квадратом другого
// bool метод
Console.WriteLine("Введите число 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool isSquare = IsSquare(num1, num2);
Console.WriteLine(isSquare ? "да" : "нет");
// сам метод
bool IsSquare(int number1, int number2)
{
    return number1 == number2 * number2 || number2 == number1 * number1; /// || -> "или" одно условие или другое &&(амперсант двойной) - "и"
}