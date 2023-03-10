//задайте одномерный массив из 123 случ чисел.
// найдите количество элементов массива, значения которых лежат в отрезке [10,99]



Console.Write("Введите размер массива : ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

FillArray(array);
PrintArray(array);
int arraySerch = ArraySerch(array);
Console.WriteLine($"Количество двузначных чисел = {arraySerch}");


void FillArray (int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 123);
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

int ArraySerch(int[] arr)
{    
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>= 10 && arr[i]<= 99) count ++;
    }
    return count;
}
