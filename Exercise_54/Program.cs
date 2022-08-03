// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

int rows = new Random().Next(2, 5);
int columns = new Random().Next(2, 5);
int[,] array = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("---");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {

        for (int k = columns - 2; k >= 0; k--)
        {
            if (array[i, k] < array[i, k + 1])
            {
                int temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp;
            }
        }
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
