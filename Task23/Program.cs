// Напишите программу, которая выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.[1,0,1,1,0,1,0,0]

using static System.Console;
Clear();

int[] arr = GetArray(10);
int[] arr1 = new int[8];  //создаем массив из 8 элементов

// FullArray(arr1);
PrintArray(arr);


// GetArray();
// PrintArray(arr);

void FullArray(int [] array)    //этот метод перебирает каждый индекс (i) массива
{
    for (int i = 0; i < array.Length; i++ )
    {
        array[i] = new Random().Next(0, 2);    // каждый элемент массива он заполняет каким то рандомным числом от 0 до 1
    }
}

int[] GetArray(int size)
{
    int[] array = new int[size];
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