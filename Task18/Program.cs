// Напишите программу, которая принимает число А и 
// выдает сумму чисел от 1 до А

using static System.Console;
Clear();
Write("Input number: ");
int number = int.Parse(ReadLine()!);
int sum = GetSum(number);
WriteLine($"Sum number 1..A = {sum}");




int GetSum(int A)
{
    int result = 0;
    while (A>0)
    {
        result += A;
        A--;
    }
    return result;
}