// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае,
//  если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

using static System.Console;
Clear();

int[,] Qwer = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7},
};

PrintArrayMatr(Qwer);

if (Qwer.GetLength(0) != Qwer.GetLength(1))
{
    WriteLine ("Can't =) ");
}
else
{
    int [,] newQwer = Reverse(Qwer);
    WriteLine();
    PrintArrayMatr(newQwer);
}


int[,] Reverse(int[,] inArray)
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[j, i] = inArray[i, j];
        }
    }
    return result;
}

void PrintArrayMatr(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3}");
        }
        WriteLine();
    }
};