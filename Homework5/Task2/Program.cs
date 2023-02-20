// Напишите программу реализующая методы формирования массива,
// заполненного случайными числами и подсчета суммы элементов,
// стоящих на нечетных позициях

using static System.Console;
Clear();

int[] arr = GetArray(9);


PrintArray(arr);

WriteLine(Result(arr));





int Result (int[] InArray)
{
    int sum = 0;
    for (int i = 1; i < InArray.Length; i++)
    {
        if (i%2 != 0) 
        {
            sum = sum + InArray[i];
        }
    }  
    return sum;
}

int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(0, 10);
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