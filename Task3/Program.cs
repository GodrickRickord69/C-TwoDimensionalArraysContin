/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Write("Введите количество сторок 1-й матрицы: ");
int rows1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов 1-й матрицы: ");
int columns1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество сторок 2-й матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов 2-й матрицы: ");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] Matr1 = GetMatr1(4, 4, 0, 10);
PrintMatr1(Matr1);

int[,] Matr2 = GetMatr2(4, 4, 0, 10);
PrintMatr2(Matr2);


int[,] GetMatr1(int m, int n, int MinValue, int MaxValue)
{
    int[,] Matr1 = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Matr1[i, j] = new Random().Next(MinValue, MaxValue);
        }
    }
    return Matr1;
}
void PrintMatr1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatr2(int m, int n, int MinValue, int MaxValue)
{
    int[,] Matr2 = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Matr2[i, j] = new Random().Next(MinValue, MaxValue);
        }
    }
    return Matr2;
}
void PrintMatr2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] resultMatr = new int[m, n];

MultiplyMatrix(Matr1, Matr2, resultMatr);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatr);

void MultiplyMatrix(int[,] Matr1, int[,] Matr2, int[,] resultMatr)
{
  for (int i = 0; i < resultMatr.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatr.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Matr1.GetLength(1); k++)
      {
        sum += Matr1[i,k] * Matr2[k,j];
      }
      resultMatr[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next();
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}