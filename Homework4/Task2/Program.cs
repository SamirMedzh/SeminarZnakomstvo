// Напишите программу реализующая метод, который принимает на вход
//  число и выдаёт сумму цифр в числе

using static System.Console;
Clear();

WriteLine("Введите число А ");
int A = int.Parse(ReadLine()!);


int N2 = sum(A);
WriteLine($"Сумма цифр в числе = {N2}");


int sum (int s)
{
    int result = 0;
    int qw = 0;
    
    while (A > 1)
    {
        qw = A%10;
        result = result + qw; 
        A = A/10;
    }

    return result;
}
