using static System.Console;

WriteLine("Являеься ли число а квадратом числа b? ");
WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите число b: ");
int b = int.Parse(ReadLine()!);

if (b * b == a)
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}