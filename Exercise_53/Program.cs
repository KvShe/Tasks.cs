// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

int rows = 4;
int columns = 4;
int[,] array = new int[rows, columns];
int[] temp = new int[columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(10);
        if (i == 0) temp[i] = array[i, j];
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("---");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (i == 0) Console.Write(array[rows - 1, j] + "\t");
        else if (i == rows - 1) Console.Write(array[0, j] + "\t");
        else Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}