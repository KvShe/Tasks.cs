// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных
// Набор данных                 Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }   0 встречается 2 раза 
//                              1 встречается 1 раз 
//                              2 встречается 1 раз 
//                              8 встречается 1 раз 
//                              9 встречается 3 раза
// Набор данных                 Частотный массив
// 1, 2, 3                      1 встречается 3 раза 
// 4, 6, 1                      2 встречается 2 раз 
// 2, 1, 6                      3 встречается 1 раз 
//                              4 встречается 1 раз 
//                              6 встречается 2 раза

int rows = new Random().Next(2, 5);
int columns = rows;
int minRandom = 1;
int maxRandom = 9;
int size = maxRandom - minRandom + 1;
int[] frequencyArray = new int[size];
for (int i = 0; i < size; i++)
{
    frequencyArray[i] = minRandom + i;
}
int[] result = new int[maxRandom];
int[,] array = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(minRandom, maxRandom + 1);
        for (int k = 0; k < size; k++)
        {
            if (frequencyArray[k] == array[i, j]) result[k]++;
        }
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine("\n");
}
for (int i = 0; i < size; i++)
{
    if (result[i] == 0) continue;
    Console.WriteLine($"{frequencyArray[i]} meet {result[i]} time");
}
