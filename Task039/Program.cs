// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

using static System.Console;
Clear();

int[,] Qwer = new int [,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {1, 4, 7, 2},
};

PrintArrayMatr(Qwer);
WriteLine();
int res = SumMatrArr2(Qwer);
WriteLine($"Сумма элементов главной диагонали = {res}");


int SumMatrArr(int[,] inArr)
{
    int sum = 0;
    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        for (int j = 0; j < inArr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += inArr[i, j];
            }
        }
    }
    return sum;
}

void PrintArrayMatr(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 3}");
        }
        WriteLine();
    }
};

//  2 СПОСОБ 


int SumMatrArr2(int[,] inArr)
{
    int sum = 0;
    for (int i = 0; i < (inArr.GetLength(0) < inArr.GetLength(1)?inArr.GetLength(0) : inArr.GetLength(1)); i++)
    {
       sum += inArr[i, i];
    }
    return sum;
}

