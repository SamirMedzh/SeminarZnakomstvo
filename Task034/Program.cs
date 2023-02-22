// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

using static System.Console;
Clear();

int[] array = { -4, -8, 4, 2 };

PrintArray(array);
ReverseArray2(array);
PrintArray(array);


void ReverseArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length ; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
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