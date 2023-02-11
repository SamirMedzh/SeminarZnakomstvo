using static System.Console;

WriteLine("Введите число ");
int a = int.Parse(ReadLine()!);

if (a%2 == 0 )
{
    WriteLine($"Да");
}
else 
{
    WriteLine($"Нет");
}