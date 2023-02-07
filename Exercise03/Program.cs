/*
Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
*/

void PrintArray2d(int[,] arrayPrint)
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

void PrintArray(int[] printArray)
{

    for (int i = 0; i < printArray.Length; i++)
    {
        Console.WriteLine($"{i} встречается {printArray[i]} раз");
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

int[] NumberItems(int[,] itemsArray2d)
{
    int[] numberOfItems = new int[10];
    for (int i = 0; i < itemsArray2d.GetLength(0); i++)
    {
        for (int j = 1; j < itemsArray2d.GetLength(1); j++)
        {
            switch (itemsArray2d[i, j])
            {
                case 0:
                {
                    numberOfItems[0]++;
                    break;
                }
                case 1:
                {
                    numberOfItems[1]++;
                    break;
                }
                case 2:
                {
                    numberOfItems[2]++;
                    break;
                }
                case 3:
                {
                    numberOfItems[3]++;
                    break;
                }
                case 4:
                {
                    numberOfItems[4]++;
                    break;
                }
                case 5:
                {
                    numberOfItems[5]++;
                    break;
                }
                case 6:
                {
                    numberOfItems[6]++;
                    break;
                }
                case 7:
                {
                    numberOfItems[7]++;
                    break;
                }
                case 8:
                {
                    numberOfItems[8]++;
                    break;
                }
                case 9:
                {
                    numberOfItems[9]++;
                    break;
                }
            }
        }
    }
    return numberOfItems;
}

int m = 3;
int n = 4;
int min = 0;
int max = 9;

int[,] array = CreateRandome2DArray(m, n, min, max);
PrintArray2d(array);

int[] numberItemsArray = NumberItems(array);

Console.WriteLine();
PrintArray(numberItemsArray);