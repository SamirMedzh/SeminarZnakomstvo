// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9] 
// Найдите сумму отрицательных и положительных элементов массива

using static System.Console;
Clear();

Write("Введите размер массива, мин и макс через пробел: ");
string[] parametrs = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries); //позволяет удалить лишние пробелы,(" ") разбили стороку на подстроки через пробел
int[] array = GetArray(int.Parse(parametrs[0]),int.Parse(parametrs[1]), int.Parse(parametrs[2]));

PrintArray(array);

WriteLine();
int negative = 0;
int positiv = 0;

foreach(int a in array)
{
    negative += a < 0? a : 0;   //если а меньше 0, то мы прибавляем а к negative, иначе прибавляем 0
    positiv  += a > 0? a : 0;
}

WriteLine($"{negative}   {positiv}");


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
    Write($"{inArray[inArray.Length - 1]}]");
}