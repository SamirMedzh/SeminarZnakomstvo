// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

using static System.Console;
Clear();

int[,] Qwer = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

PrintArrayMatr(Qwer);

int[] Temp = new int[Qwer.GetLength(1)];

for (int i = 0; i < Qwer.GetLength(1); i++)
{
    Temp[i] = Qwer[0, i];
    Qwer[0, i] = Qwer[Qwer.GetLength(0) - 1, i];
    Qwer[Qwer.GetLength(0) - 1, i] = Temp[i];
}

WriteLine();
PrintArrayMatr(Qwer);


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