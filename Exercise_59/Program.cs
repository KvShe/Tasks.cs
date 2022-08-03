// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива

int rows = new Random().Next(2, 7);
int colomns = rows;
int[,] array = new int[rows, colomns];
int min = int.MaxValue;
int minIndexRow = 0;
int minIndexColumns = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colomns; j++)
    {
        array[i, j] = new Random().Next(10);
        if (min > array[i, j])
        {
            min = array[i, j];
            minIndexRow = i;
            minIndexColumns = j;
        }
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine("\n");
}
Console.WriteLine($"\nMin = {min}");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colomns; j++)
    {
        if (i == minIndexRow || j == minIndexColumns) Console.Write("\t");
        else Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine("\n");
}
