// Напишите программу, которая выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.[1,0,1,1,0,1,0,0]

using static System.Console;
Clear();

int[] array = InitBinaryArray();
PrintArray(array);

int[] InitBinaryArray()
{
    int[] res = new int[8];
    
    for (int i = 0; i < res.Length; i++ )
    {
        Random ran = new Random();
        res[i] =ran.Next(0, 2);
    }
    return res;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++ )
    {
        Write($"{arr[i]}");
    }
}