// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

using static System.Console;
Clear();

Write("Введите число для перевода в двоичную систему: ");
int Number = int.Parse(ReadLine()!);

// WriteLine($"{Number%2}");
// WriteLine($"{Number/2}");

WriteLine(BinaryNumber(Number));

string BinaryNumber (int numb)
{
    if(numb == 0) return "0";
    string result = string.Empty;
    int rem;
    while (numb>0)
    {
        rem = numb%2;
        numb /=2;
        result = rem.ToString() + result;
    }
    return result;
}
