// напишите программу замена элементов массива:
// положительные элементы замените на соответ. отрицательные и на оборот.
//например [-4 -8 8 2] ->[4 8 -8 -2]

Console.Write("Введите размер массива : ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arraySize];

FillArray(array);
PrintArray(array);
EditArray(array);
PrinntArray(array);

void FillArray (int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-10,10);
    }
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}

void EditArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}
