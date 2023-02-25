// 1. На вход принимает число
// 2. выдает его квадрат(число умноженное само на себя)




Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;                               // square - возведение в квадрат
Console.WriteLine($"Квадрат числа {number} = {square}");   // интраполяция строки с помощью $ и {}, позволяет из просто текста превратить изменяемые переменные