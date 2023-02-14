// Напишите программу, которая на вход принимает число (N)
// и выдает таблицу квадратов чисел от 1 дор N

using static System.Console;
Clear();
int i = 1;

Write("Введите число для вывода квадратов от 1 до числа: ");
int N = int.Parse(ReadLine()!);
// int.TryParse(ReadLine(), out int N);



 while( i <= N)
 {
     WriteLine($"Квадрат числа {i} = {Math.Pow(i, 2)}");
     i++;
 }