// Напишите программу реализующая метод, который формирует
// массив случайных целых чисел из 8 элементов и выводит их на экран

using static System.Console;
Clear();

int[] ARR = GetArray(8);
PrintArray(ARR);



int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++ )
    {
        array[i] = new Random().Next(10);
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        Write($"{array[i]}");
    }
}