using static System.Console;

WriteLine("Введите число a: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число b: ");
int b = Convert.ToInt32(ReadLine());

WriteLine(a%b==0?"кратно":$"некратно, остаток {a%b}");