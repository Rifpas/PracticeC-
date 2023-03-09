/// выводит массив из 8 элементов, 
/// заполненый нулями и единицами в случайном порядке

int[] array = new int[8]; /// 0 1 2 3 4 5 6 7

Array(array);
WriteArray(array);

void Array(int[] arr)
{
    Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    array[i] = rand.Next(0, 2);
    
}
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}