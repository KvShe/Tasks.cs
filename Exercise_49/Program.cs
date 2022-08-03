// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
int[,] array = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine("\n");
}
Console.WriteLine();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine("\n");
}
