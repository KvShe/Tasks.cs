// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int rows = new Random().Next(2, 5);
int columns = new Random().Next(2, 5);
int[,] array = new int[rows, columns];
int sum = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(10);
        if (i == j) sum += array[i, j];
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine("\n");
}
Console.WriteLine($"The sum of the diagonal elements = {sum}");
