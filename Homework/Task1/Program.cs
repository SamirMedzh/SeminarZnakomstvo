using static System.Console;

Write("Введите число a ");
int a = int.Parse(ReadLine()!);

Write("Введите число b ");
int b = int.Parse(ReadLine()!);

if (a>b)
{
   WriteLine($"max = {a}");
   WriteLine($"min = {b}");
}
else
{
    WriteLine($"min = {a}");
    WriteLine($"max = {b}");
}
