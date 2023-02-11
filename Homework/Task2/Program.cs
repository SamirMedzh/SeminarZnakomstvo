using static System.Console;

WriteLine("Введите число a");
int a = int.Parse(ReadLine());

WriteLine("Введите число b");
int b = int.Parse(ReadLine());

WriteLine("Введите число c");
int c = int.Parse(ReadLine());

if (a > b)
{
    if (a > c)
    WriteLine($"max = {a}");
    else
    WriteLine($"max = {c}");
}
else
    if (b > c)
    WriteLine($"max = {b}");
    else
    WriteLine($"max = {c}");
