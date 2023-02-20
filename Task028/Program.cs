// Найдите произведение пар чисел в одномерном массиве. парой считается первый и последний элемент
// второй и предпоследний и т.д. Результат напишите в новом массиве


using static System.Console;
Clear();

int[] array = GetArray(9);
PrintArray(array);
int[] array2 = multiPara(array);
PrintArray(array2);


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

int[] multiPara(int[] inarray)
{
    int size = inarray.Length / 2;
    if (inarray.Length % 2 == 1) size++;      // Если значение нечетное то добавляем на один размер массив

    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = inarray[i] * inarray[inarray.Length - i - 1];    // здесь создаются новый массив,умноженается первое число и последнее
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
    WriteLine($"{inArray[inArray.Length - 1]}]");
}