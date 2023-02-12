using static System.Console;
Clear();


Write("Введите координаты x: ");
int x = int.Parse(ReadLine()!);
Write("Введите координаты y: ");
int y = int.Parse(ReadLine()!);

if (x == 0 || y == 0)
{
   WriteLine("Error");
   return;
}
if (x > 0 && y > 0)
{
   WriteLine("I четверть");
   return;
}
if (x < 0 && y > 0)
{
   WriteLine("II четверть");
   return;
}
if (x < 0 && y < 0)
{
   WriteLine("III четверть");
   return;
}
if (x > 0 && y < 0)
{
   WriteLine("IV четверть");
   return;
}