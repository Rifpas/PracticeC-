//  Напишите цикл, который принимает на вход два числа (A и B)
//   и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число A");
Console.Write("A = ");
int numberA= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
Console.Write("B = ");
int numberB= Convert.ToInt32(Console.ReadLine());


int DegreeNumbers = NaturalDegree(numberA, numberB);
    Console.WriteLine($" Число A в степени B = {DegreeNumbers}");

int NaturalDegree(int numA, int numB)
{
    int degree = 1;
    for (int i = 0; i < numB; i++)
    {
        degree*= numA;
    }
    return degree;
}


