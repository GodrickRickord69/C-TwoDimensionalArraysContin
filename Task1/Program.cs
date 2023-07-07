/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


Console.Write("Введите количество сторок: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);
OrderingRow(array);



int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(MinValue, MaxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
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

int [,] OrderingRow(int[,] array)
{
    int [,] OrderingArray = new int[array.GetLength(0), array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int MaxI = array[0,0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] > MaxI)
            {
                MaxI = array[i,j];
                OrderingArrayMaxI = i;
                OrderingArrayMaxJ = j;
            }
            //Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return 
}