Console.WriteLine("Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника");
int size;
bool checkFormat = false;
do
{
    Console.Write("Enter size: ");
    checkFormat = int.TryParse(Console.ReadLine(), out size);
} while (!checkFormat || size < 0);
size++;

int[,] array = new int[size, size];
for (int i = 1; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (j == 0) array[i, j] = 1;
        if (i > 0 && j > 0) array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
    }
}
const int cellWidth = 2;
int firstCoordinate = cellWidth * size;
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.SetCursorPosition(firstCoordinate, i + 1);
        if (array[i, j] != 0) Console.Write($"{array[i, j],cellWidth}");
        firstCoordinate += cellWidth * 2;
    }
    firstCoordinate = cellWidth * size - cellWidth * (i + 1);
}
