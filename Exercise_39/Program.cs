// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int size = new Random().Next(1, 10);
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(10);
}
Console.WriteLine($"[{String.Join(", ", array)}]");
for (int i = 0; i < size / 2; i++)
{
    int temp = array[i];
    array[i] = array[^(i + 1)];
    array[^(i + 1)] = temp;
}
Console.WriteLine($"[{String.Join(", ", array)}]");