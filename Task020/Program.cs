// Напишите программу, которая принимает на вход число N
// и выдаёт произведения чисел от 1 до N

using static System.Console;
Clear();

WriteLine("Введите число N ");
int N = int.Parse(ReadLine()!);
int N2 = sum(N );
WriteLine($"Сумма произседений чисел от 1 до {N} = {N2}");


int sum (int A)
{
    int result = 1;
    while (A > 1)
    {
        result = result * A;
        A--;
    }
    return result;
}