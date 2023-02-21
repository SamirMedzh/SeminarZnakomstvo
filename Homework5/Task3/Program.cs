// Напишите программу реализующая методы формирования массива,
// заполненного случайными  вещественными числами и вычесления 
// разницы между макс и мин элементов массива

using static System.Console;
Clear();

int ArraySize = 5;
int RangeDown = 0;
int RangeUp = 100;
double[] arr = GetArray(ArraySize, RangeDown, RangeUp);
int j = 0;
PrintArray(arr);

double MaxArray = arr[j];
double MinArray = arr[j];

foreach (var a in arr)
{
    if (a > MaxArray) MaxArray = a;
    if (a < MinArray) MinArray = a;
}

WriteLine();
WriteLine($"{MaxArray - MinArray:f1}");

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] resultArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }

    return resultArray;
}

void PrintArray(double[] inArray)                  // Этот метод, красиво выводит массив в квадр скобках через запятые,- 1 поставил чтоб последний элемент выводился без запятой
{                                               // послед элемент вставил во второй ВРАЙТ и закрыл квадр скобкой                                         
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
           Write($"{inArray[i]:f1}; "); 
    }
    Write($"{inArray[inArray.Length - 1]:f1}]");
}