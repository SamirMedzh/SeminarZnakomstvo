// 6 знаков в билете, является ли он счастливым
// первая сумма 3 знаков должна бфыть равна сумме вторых 3 зн

using static System.Console;
Clear();


Write("Введите номер билета : ");
string ticket = ReadLine();

bool Ticket(int numb)
{
    int a = numb / 100000;
    int b = (numb / 10000) % 10;
    int c = (numb / 1000) % 10;
    int d = (numb / 1000) / 100;
    int e = (numb / 1000) / 10 % 10;
    int f = (numb / 1000) % 10;

    return(a + b + c == d + e + f);
}


