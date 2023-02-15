// Напишите программу, которая принимает на вход число N
// и выдаёт сумму чисел от 1 до N, на которые N делится без остатка


using static System.Console;
Clear();
Write("Напишите число N: ");
int number = int.Parse(ReadLine()!);
int sum = GetSum(number);
WriteLine($"сумму чисел = {sum}");






int GetSum(int A)
{
    int result = 0;
    int temp = A;

    while (A > 0)
    {
        if (temp % A == 0)
        {   
            result += A;
        }
        
        A--; 
    }

    return result;
    
}
