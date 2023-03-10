// найдите призведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//результат записать в новом массиве

Console.Write("Введите размер массива : ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

FillArray(array);
PrintArray(array);
int[] productOfNumbers = ProductOfNumbers(array);
PrintArray(productOfNumbers);

void FillArray (int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 10);
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

int[] ProductOfNumbers(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length%2 != 0) size +=1;
        int []newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length-1-i];
    }
    if (arr.Length%2 != 0)
        newArray[size - 1] = arr[arr.Length/2];
    return newArray;
}


