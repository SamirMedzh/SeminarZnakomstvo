using static System.Console;

WriteLine("Введите число a: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число b: ");
int b = Convert.ToInt32(ReadLine());

WriteLine(a*a == b? "b является квадр а" : 
          b*b == a? "а является квадратом b"
          : "не являются квадр друг друга");
