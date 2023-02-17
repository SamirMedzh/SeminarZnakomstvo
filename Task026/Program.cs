// Задайте массив. Напишите программу которая определяет, 
// присутствует данное число в массиве
// 4; [3, 5, 6, 8] нет
// 3; [3, 9, 5, 45] да

using static System.Console;
Clear();

WriteLine("Введите число ");
int N = int.Parse(ReadLine()!);

int[] array = { -4, -8, 4, 2 };

// bool result = ArrayLookUp(array, N);
// WriteLine(result);

WriteLine(ArrayLookUp(array, N)? "Да" : "Нет");

bool ArrayLookUp(int[] inArray, int number)
{
    foreach(int a in inArray)
    {
        if (number == a)return true;
    }
    return false;
}






