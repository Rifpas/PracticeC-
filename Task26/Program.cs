//принимает число и выдает количество цифр в числе


Console.WriteLine(" Введите число: ");
int Digit = Convert.ToInt32(Console.ReadLine());

int iDigit = Idigit(Digit);
Console.WriteLine($" В числе {Digit} = {iDigit} цифры");


int Idigit(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
