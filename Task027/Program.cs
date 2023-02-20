// Задайте одномерный массив из 123 случайных чисел. Найдите кол-во элементов
// массива, значения которых лежат в отрезке [ 10,99].

using static System.Console;
Clear();

// Write("Введите размер массива, мин и макс через пробел: ");
// string[] parametrs = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries); 

int[] array = GetArray(123, -100, 100);

PrintArray(array);
WriteLine();                    //Этот Врайтлайн нужен для переноса значения WriteLine(ArrayCount(array) на строчку ниже
WriteLine(ArrayCount(array));


int ArrayCount(int[] InArray)
{
    int result = 0;
    foreach (int i in InArray)
    {
        if (i >= 10 && i <= 99)result++;
        
    }
    return result;
}

int[] GetArray(int size, int minValue, int maxValue)    // Создадим метод который формирут массив в указанном диапазоне и указанногот размера
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++ )
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1 );
    }

    return resultArray;
} 

void PrintArray(int[] inArray)                  // Этот метод, красиво выводит массив в квадр скобках через запятые,- 1 поставил чтоб последний элемент выводился без запятой
{                                               // послед элемент вставил во второй ВРАЙТ и закрыл квадр скобкой                                         
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
           Write($"{inArray[i]},"); 
    }
    WriteLine($"{inArray[inArray.Length - 1]}]");
}