// Вывести длину отрезка

using static System.Console;
Clear();

WriteLine("Введите координаты А через пробел: ");
Point A = getPointFromString(ReadLine()!);
WriteLine("Введите координаты B через пробел: ");
Point B = getPointFromString(ReadLine()!);

double delta = Math.Sqrt(Math.Pow(A.x - B.x,2) + Math.Pow(A.y - B.y,2));
WriteLine(delta);

Point getPointFromString(string ihStr)
{
    Point res = new Point();
    string[] par = ihStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    res.x = int.Parse(par[0]);
    res.y = int.Parse(par[1]);
    return res;
}
struct Point 
{
    public int x;
    public int y;
}
















