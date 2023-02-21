// Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.

using static System.Console;
Clear();

int a = AskUserForNumber("Введите сторону треугольника а : ");
int b = AskUserForNumber("Введите сторону треугольника b : ");
int c = AskUserForNumber("Введите сторону треугольника c : ");

WriteLine(IsTriangle(a,b,c)? $"Треугольник сторонами {a}, {b} и {c} сущуствует." : 
$"Треугольник сторонами {a}, {b} и {c} не сущуствует.");


bool IsTriangle (int inA, int inB,int inC)
{
    if(a + b > c && a + c > b && c + b > a) return true;
    return false;
}

int AskUserForNumber(string inPromt)
{
    int resultNum = 0;
    string UserInput = "";
    while (!int.TryParse(UserInput,out resultNum))
    {
        Console.Write(inPromt);
        UserInput = Console.ReadLine()!;
    }
    return resultNum;
}

