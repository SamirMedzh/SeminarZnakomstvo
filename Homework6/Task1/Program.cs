// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



using static System.Console;
Clear();

Write("Введите числа через пробел: ");
string[] parametrs = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[] array = Array.ConvertAll(parametrs, int.Parse);  // перевод из str в int
int positive = NumbEven(array);
// WriteLine($"{parametrs}");

PrintArray(array);
WriteLine();
WriteLine($"Положительных чисел: {positive}");


int NumbEven(int[]inarray)
{
    int result = 0;
    for (int i = 0; i < inarray.Length; i++)
    {
        if (inarray[i] > 0) result++;
    }
    return result;
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
