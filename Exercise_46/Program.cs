// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
int[,] array = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine("\n");
}
