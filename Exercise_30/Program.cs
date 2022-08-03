// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int size = new Random().Next(1, 10);
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(2);
}
Console.WriteLine($"[{String.Join(", ", array)}]");