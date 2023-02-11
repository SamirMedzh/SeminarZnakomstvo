using static System.Console;

WriteLine("Введите число N");
int N = int.Parse(ReadLine()!);

int index = 0;

while (N > index)
{
    if (index%2 == 0)
     Write(index);
     index++;
}






