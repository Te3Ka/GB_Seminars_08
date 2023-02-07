/*
Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
*/

int factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}

void PascalTriangle(int num)
{
    for (int i = 0; i < num; i++)
    {
        for (int c = 0; c <= (num - i); c++)
        {
            Console.Write(" ");
        }
        for (int c = 0; c <= i; c++)
        {
            Console.Write(" ");
            Console.Write(factorial(i) / (factorial(c) * (factorial(i - c))));
        }
        Console.WriteLine();
    }
}

int N = 10;
PascalTriangle(N);