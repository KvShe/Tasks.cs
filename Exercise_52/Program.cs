// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = new Random().Next(2, 5);
int columns = new Random().Next(2, 5);
int[,] array = new int[rows, columns];
double[] sumColumns = new double[columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(10);
        sumColumns[j] += array[i, j];
        Console.Write(array[i, j] + "\t");
    }

    Console.WriteLine();
}
Console.WriteLine("---");
for (int i = 0; i < columns; i++)
{
    Console.Write(sumColumns[i] + "\t");
    sumColumns[i] /= rows;
    sumColumns[i] = Math.Round(sumColumns[i], 2);
}
Console.WriteLine($"\n---\n"
                + $"{String.Join("\t", sumColumns)}");
