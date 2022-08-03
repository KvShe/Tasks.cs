// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

int rows = new Random().Next(2,5);
int columns = new Random().Next(2,5);
int[,] array = new int[rows, columns];
int[] sumRows = new int[rows];
int min = int.MaxValue;
int minIndex = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i,j] = new Random().Next(10);
        sumRows[i] += array[i,j];
        Console.Write(array[i,j] + "\t");
    }
    if (min > sumRows[i])
    {
        min = sumRows[i];
        minIndex = i;
    }
    Console.Write("Sum rows = " + sumRows[i]);
    Console.WriteLine();
}
Console.WriteLine($"В {minIndex + 1} строке наименьшая сумма элементов");
