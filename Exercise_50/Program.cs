// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int EnterNumber()
{
    int number;
    bool checkFormat = false;
    do
    {
        Console.Write("Enter number: ");
        checkFormat = int.TryParse(Console.ReadLine(), out number);
    } while (!checkFormat);
    return number;
}
int firstPosition = EnterNumber() - 1;
int secondPosition = EnterNumber() - 1;
bool checkPosition = false;
int result = 0;

int rows = new Random().Next(2, 5);
int columns = new Random().Next(2, 5);
int[,] array = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(10);
        if (i == firstPosition && j == secondPosition)
        {
            checkPosition = true;
            result = array[i, j];
        }
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine("\n");
}
if (checkPosition == true) Console.WriteLine($"На position [{firstPosition}, {secondPosition}] находится элемент = {result}");
else Console.WriteLine($"На position [{firstPosition}, {secondPosition}] no элемента");
