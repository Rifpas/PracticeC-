//на вход два числа,
//
// 

Console.WriteLine("Input N : ");
int num1 = Convert.ToInt32(Console.ReadLine()); 

Square(num1);
void Square(int num)
{
    int i = 1;
    while (i <= num1)
    {
        Console.WriteLine($"{i} -> {Math.Pow(i, 2)}"); 
        // Math.Pow(i
        i++;
    }
}


///{i} -> {i * i}