// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] array = CreateArrayRndDouble( 6, 0, 100);
PrintArrayDouble(array);

double MaxNumberArray = maxNumArray(array);
Console.WriteLine($"Максимальный элемент = {MaxNumberArray}");

double MinNumberArray = minNumArray(array);
Console.WriteLine($"Минимальный Элемент = {MinNumberArray}");

double DifferenceNum = DiffNumber (MaxNumberArray, MinNumberArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом = {DifferenceNum}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double maxNumArray (double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

double minNumArray (double[] arr)
{
    double min = 100;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

double DiffNumber (double MaxNum, double MinNum )
{
    double Number = MaxNum - MinNum;
    return Math.Round(Number, 1);
}
