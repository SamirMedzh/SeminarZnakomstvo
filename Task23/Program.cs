// Напишите программу, которая выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.[1,0,1,1,0,1,0,0]

using static System.Console;
Clear();

int[] arr = GetArray();
int[] arr1 = new int[8];  //создаем массив из 8 элементов

GetArray();
PrintArray(arr);

void FullArray(int [] array)    //этот метод перебирает каждый индекс (i) массива
{
    for (int i = 0; i < array.Length; i++ )
    {
        array[i] = new Random().Next(2);    // каждый элемент массива он заполняет каким то рандомным числом от 0 до 1
    }
}

int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++ )
    {
        array[i] = new Random().Next(2);
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