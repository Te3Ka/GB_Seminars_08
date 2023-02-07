/*
Задайте двумерный массив.
Напишите программу, которая поменяет местами первую и последнюю строку массива.

*/

void PrintArray(int[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayPrint[i,j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandome2DArray(int m, int n, int min, int max)
{
    int[,] array2D = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i,j] = random.Next(min, max + 1);
        }
    }
    return array2D;
}

int[,] SwapStringArray2d(int[,] oldArray)
{
    int temp = 0;
    for (int i = 0; i < oldArray.GetLength(1); i++)
    {
        temp = oldArray[oldArray.GetLength(0) - 1, i];
        oldArray[oldArray.GetLength(0) - 1, i] = oldArray[0, i];
        oldArray[0, i] = temp;
    }
    return oldArray;
}

int m = 5;
int n = 7;
int min = 0;
int max = 9;

int[,] array = CreateRandome2DArray(m, n, min, max);
PrintArray(array);

int[,] swapArray = SwapStringArray2d(array);
Console.WriteLine();
PrintArray(swapArray);