//Какого цвета клетка шахматной доски, если начинается с черной


using static System.Console;
Clear();

Write("Введите номер доски ");

string parametrs = ReadLine();
int par1 = parametrs[0];
int par2 = parametrs[1];

WriteLine(par1);
WriteLine(par2);

if ((par1 + par2)%2 == 0)
{
    Write("Чёрное ");
}
else
{
    Write("Белое ");
}
