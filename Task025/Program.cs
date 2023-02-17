// Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот [-4,-8,4,2 ] => [4,8,-4,-2]

using static System.Console;
Clear();

int[] array = { -4, -8, 4, 2 };

ReverseArray(array);
PrintArray(array);


void PrintArray(int[] inArray)                  
{                                              
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
           Write($"{inArray[i]},"); 
    }
    Write($"{inArray[inArray.Length - 1]}]");
}

void ReverseArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++ )
    {
        array1[i] *= -1 ;
    }
}