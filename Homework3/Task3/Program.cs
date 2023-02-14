// Напишите программу, которая на вход принимает число (N)
// и выдает таблицу кубов чисел от 1 дор N

using static System.Console;
Clear();
int i = 1;

Write("Введите число для вывода кубов от 1 до числа: ");
int N = int.Parse(ReadLine()!);
// int.TryParse(ReadLine(), out int N);



 while( i <= N)
 {
     WriteLine($"Куб числа {i} = {Math.Pow(i, 3)}");
     i++;
 }