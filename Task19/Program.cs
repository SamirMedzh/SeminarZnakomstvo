// Написать программу, которая принимает на вход число 
// и выдаёт количество цифр в числе

using static System.Console;
Clear();
Write("Напишите число: ");
int number = int.Parse(ReadLine()!);
int sum = GetSum(number);
WriteLine($"Количество цифр = {sum}");






int GetSum(int A)
{
    int result = 0;
    
    while (A > 1)
    {
        result = result + 1;
        A = A / 10; 
    }

    return result;
    
}


// int[] array = { 1, 12, 23, 34, 43, 43, 33, 66 };

// int n = array.Length;
// int find = 43;

// int index = 0;

// while (index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }