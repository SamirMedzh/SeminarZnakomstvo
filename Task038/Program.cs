// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените 
// эти элементы на их квадраты. Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

using static System.Console;
Clear();

int[,] Qwer = GetMatrArray(3, 6);

PrintArrayMatr(Qwer);

WriteLine();
ReverseArray(Qwer);
PrintArrayMatr(Qwer);


void ReverseArray(int[,] inArr)
{
    // int[,] newArray = new int[inArr.GetLength(0), inArr.GetLength(1)];
    for (int i = 1; i < inArr.GetLength(0); i++)
    {
        for (int j = 1; j < inArr.GetLength(1); j++)
        {
            if ((i % 2 == 0 && i != 0) && (j % 2 == 0 && j != 0))
            {
                inArr[i, j] = inArr[i, j] * inArr[i, j];
            }
            else
            {
                inArr[i, j] = inArr[i, j];
            }
        }
    }
}

int[,] GetMatrArray(int rows, int columns)
{
    int[,] Arr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Arr[i, j] = rnd.Next(1, 10);
        }
    }
    return Arr;
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
}

