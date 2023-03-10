// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//
//4; [6 7 19 345 3] ->нет
//3; [6 7 19 345 3] ->да


Console.Write("Введите размер массива : ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];


FillArray(array);
PrintArray(array);
Console.Write("Введите число, которое будем искать в массиве : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(ArraySearch(array, number) ? "Yes" : "No");

void FillArray (int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-10, 10);
    }
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

bool ArraySearch(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number) return true;
    }
    return false;
}