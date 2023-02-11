using static System.Console;

WriteLine("Являеься номер дня недели? ");
int a = int.Parse(ReadLine()!);

if (a <= 7 && a >=1)
{
    if (a == 1)
    {
        Write("Понедельник");
    }
    if (a == 2)
    {
        Write("Вторник");
    }
    if (a == 3)
    {
        Write("Среда");
    }
    if (a == 4)
    {
        Write("Четверг");
    }
    if (a == 5)
    {
        Write("Пятница");
    }
    if (a == 6)
    {
        Write("Суббота");
    }
    if (a == 7)
    {
        Write("Воскресенье");
    }
}
else
{
    Write("Данного дня недели не существует ");
}