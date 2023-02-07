/*
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

void PrintArray(int[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayPrint[i, j]}, ");
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
            array2D[i, j] = random.Next(min, max + 1);
        }
    }
    return array2D;
}

int[,] SwapArray2d(int[,] oldArray)
{
    int[,] newArray = new int[oldArray.GetLength(1), oldArray.GetLength(0)];
    for (int i = 0; i < oldArray.GetLength(1); i++)
    {
        for (int j = 0; j < oldArray.GetLength(0); j++)
        {
            newArray[i, j] = oldArray[j, i];
        }
    }
    return newArray;
}

int m = 1;
int n = 1;
int min = 0;
int max = 9;

int[,] array = CreateRandome2DArray(m, n, min, max);
PrintArray(array);

int[,] arraySwap = SwapArray2d(array);
Console.WriteLine();
PrintArray(arraySwap);