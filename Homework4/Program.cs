// Напишите программу реализующая метод, которая принимает на вход 
// 2 числа (А и В) и возводит число А в натуральную степень В с использованием цикла

using static System.Console;
Clear();

WriteLine("Введите число А ");
int A = int.Parse(ReadLine()!);

WriteLine("Введите число B ");
int B = int.Parse(ReadLine()!);

int N2 = sum(A);
WriteLine($"А в степени В = {N2}");


int sum (int s)
{
    int result = 1;
    int i = 1;
    while (B >= i)
    {
        result =result * A;
        i++;
    }
    return result;
}