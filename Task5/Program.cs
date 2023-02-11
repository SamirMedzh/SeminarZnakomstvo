using static System.Console;

Write("Введите число ");
int a = int.Parse(ReadLine()!);

if (a>= 100 && a <= 999) WriteLine(a%10);
else Write("Введено не трехзначное число");