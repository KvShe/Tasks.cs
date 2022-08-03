// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int rows = new Random().Next(2, 5);
int columns = rows;
int[,] firstMatrix = new int[rows, columns];
int[,] secondMatrix = new int[rows, columns];
int[,] productMatrix = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        firstMatrix[i, j] = new Random().Next(10);
        secondMatrix[i, j] = new Random().Next(10);
        productMatrix[i,j] = firstMatrix[i,j] * secondMatrix[i,j];
    }
}
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
PrintMatrix(productMatrix);