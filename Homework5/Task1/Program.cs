// Напишите программу реализующая методы формирования массива,
// заполненного случайными положительными 3x значчислами и подсчета
// кол-ва четных чисел массива

using static System.Console;
Clear();

int[] arr = GetArray(1);

PrintArray(arr);
WriteLine();
WriteLine(ResultEven(arr));




int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(100, 1000);
    }

    return resultArray;
}

int ResultEven (int[] InArray)
{
    int sum = 0;
    for (int i = 0; i < InArray.Length; i++)
    {
        if (InArray[i] % 2 == 0)
        {
            sum++;
        } 
    }  
    return sum;
}

void PrintArray(int[] inArray)                  // Этот метод, красиво выводит массив в квадр скобках через запятые,- 1 поставил чтоб последний элемент выводился без запятой
{                                               // послед элемент вставил во второй ВРАЙТ и закрыл квадр скобкой                                         
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
           Write($"{inArray[i]},"); 
    }
    Write($"{inArray[inArray.Length - 1]}]");
}