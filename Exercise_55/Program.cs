// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя

int rows = new Random().Next(2,5);
int columns = new Random().Next(2,5);
int[,] array = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("---");
for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write(array[j,i] + "\t");
    }
    Console.WriteLine();
}
