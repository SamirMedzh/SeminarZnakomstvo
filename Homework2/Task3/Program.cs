// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6



using static System.Console;

WriteLine("Введите число ");
int a = Convert.ToInt32(ReadLine());

if (a > 99)
{
   a = a / 100;
   a = a % 10;
   WriteLine($"Третья цифра {a}");
}  
else
{
    WriteLine("Третьей цифры нет");
}
   
   
   ;












////while (a<10)
//{
////    if(a<10)
//Write(a);
//a = a / 10;
//}
//else
//{    
//WriteLine(a = a / 10);
//}