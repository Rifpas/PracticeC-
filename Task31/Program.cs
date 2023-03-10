//1.массив из 12 эл -ов, 
//2.заполненый случайными числами из промежутка [-9,9]
//3.Найдите сумму отриц и положит элементов массива
// пример: [3 9 8 1 0 -7 2 -1 8 -3 -1 6] сумма положительных равна 29, отриц -20




int[] array = CreateArrayRndInt( 12, -9, 9);
PrintArray(array);

int SumNegativeElem = GetSumNegativeElem(array);
int SumPositiveElem = GetSumPositiveElem(array);
Console.WriteLine($"Сумма  элементов = {SumNegativeElem}");
Console.WriteLine($"Сумма положительных элементов = {SumPositiveElem}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}