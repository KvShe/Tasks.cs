// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// 3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = new Random().Next(1, 10);
int[] array = new int[size];
int sum = 0;
for (int i = 0; i < size; i = i + 2)
{
    array[i] = new Random().Next(10);
    sum += array[i];
}
Console.WriteLine($"[{String.Join(", ", array)}]\n"
                + $"Сумма элементов на не чётных позициях = {sum}");
                