// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int size = new Random().Next(1, 10);
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(10);
}
int length = 0;
if (size % 2 == 0) length = size / 2;
else length = size / 2 + 1;
int[] arrayResult = new int[length];
for (int i = 0; i < length; i++)
{
    int maxIndex = length - 1;
    if (i == maxIndex) arrayResult[i] = array[i];
    else arrayResult[i] = array[i] + array[^ (1 + i)];
}
Console.WriteLine($"[{String.Join(", ", array)}]\n"
                + $"[{String.Join(", ", arrayResult)}]");
