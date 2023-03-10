// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[]array = new int[8];

    
Array(array);
WriteArray(array);

void Array(int[]arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
{
   array[i] = rand.Next(0, 35);                         
   Console.Write(array[i] + ", " );
}
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
}
