// Напишите программу, которая принимает на вход координаты 2 точек
// и находит расстояние между ними в 3D пространстве;

using static System.Console;
Clear();


Write("Точка А -> Введите координаты x: ");
int ax = int.Parse(ReadLine()!);
Write("Точка А -> Введите координаты y: ");
int ay = int.Parse(ReadLine()!);
Write("Точка А -> Введите координаты z: ");
int az = int.Parse(ReadLine()!);
Write("Точка B -> Введите координаты x: ");
int bx = int.Parse(ReadLine()!);
Write("Точка B -> Введите координаты y: ");
int by = int.Parse(ReadLine()!);
Write("Точка B -> Введите координаты z: ");
int bz = int.Parse(ReadLine()!);

// Math.Pow() - возведение в степень
// Math.Sqrt() - извлекает квадратный корень
// С(квадрат) = А(квадрат) + В(квадрат)  -   Теорема Пифагора

double length = Math.Sqrt(Math.Pow((ax - bx),2) + Math.Pow((ay - by),2) + Math.Pow((az - bz),2));

// WriteLine(length);

 WriteLine($"{length:f2}"); //f2 это округление