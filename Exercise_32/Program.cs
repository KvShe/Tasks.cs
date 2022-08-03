// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int size = new Random().Next(2, 10);
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-9, 10);
    System.Console.Write($"{array[i]}  ");
    array[i] *= -1;
    System.Console.WriteLine(array[i]);
}
