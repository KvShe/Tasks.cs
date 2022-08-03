// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования

int size = new Random().Next(1, 10);
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(10);
}
int[] copyArray = new int[size];
for (int i = 0; i < size; i++)
{
    copyArray[i] = array[i];
}
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"[{String.Join(", ", copyArray)}]");
