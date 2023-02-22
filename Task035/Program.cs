// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

using static System.Console;
Clear();

Write("Введите число N: ");
int Number = int.Parse(ReadLine()!);

// 1 Способ решения

PrintArray(Fibonacci(Number));

int[] Fibonacci(int numb)
{
    int[] result = new int[numb];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < numb; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
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

//  2 способ решения


void FibonaCCi(int numb)
{
    int temp, num1 = 0, num2 = 1;
    Write($"{num1} {num2} ");
    for (int i = 2; i < numb; i++)
    {
        temp = num1 + num2;
        num1 = num2;
        num2 = temp;
        Write($"{num2} ");
    }
}
