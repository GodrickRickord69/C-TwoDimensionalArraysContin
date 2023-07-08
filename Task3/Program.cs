/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] Matr1 = GetRandomMatr(4, 4, 0, 10);
PrintMatr(Matr1);

int[,] Matr2 = GetRandomMatr(4, 4, 0, 10);
PrintMatr(Matr2);

Console.WriteLine("Произведение первой и второй матриц:");
MultiplyMatrix(Matr1, Matr2);

int[,] GetRandomMatr(int m, int n, int MinValue, int MaxValue)
{
    int[,] Matr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Matr[i, j] = new Random().Next(MinValue, MaxValue);
        }
    }
    return Matr;
}

void PrintMatr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplyMatrix(int[,] Matr1, int[,] Matr2)
{
    int[,] resultMatr = new int[Matr1.GetLength(0), Matr1.GetLength(1)];

    for (int i = 0; i < resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < resultMatr.GetLength(1); k++)
            {
                sum += Matr1[i, k] * Matr2[k, j];
            }
            resultMatr[i, j] = sum;
        }
    }
    PrintMatr(resultMatr);
}