// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int firstSize = 2;
int secondSize = 2;
int thirdSize = 2;

int step = 4;
int minRandom = 0;
int maxRandom = step;

int[,,] array = new int[firstSize, secondSize, thirdSize];
for (int i = 0; i < firstSize; i++)
{
    for (int j = 0; j < secondSize; j++)
    {
        for (int k = 0; k < thirdSize; k++)
        {
            array[i,j,k] = new Random().Next(minRandom, maxRandom);
            minRandom += step;
            maxRandom += step;
            Console.Write(array[i, j, k] + "\t");
        }
        Console.Write("\t");
    }
    Console.WriteLine("\n");
}
for (int i = 0; i < firstSize; i++)
{
    for (int j = 0; j < secondSize; j++)
    {
        for (int k = 0; k < thirdSize; k++)
        {
            Console.WriteLine($"{array[i,j,k]}\t[{i}, {j}, {k}]");
        }
    }
}
