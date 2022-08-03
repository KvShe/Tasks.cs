// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int number;
bool checkPoint = false;
do
{
    Console.Write("Enter number: ");
    checkPoint = int.TryParse(Console.ReadLine(), out number);
} while (checkPoint == false);
int size = new Random().Next(1, 10);
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(10);
    if (array[i] == number)
    {
        checkPoint = false;
        break;
    }
}
if (checkPoint == false) Console.WriteLine($"[{String.Join(", ", array)}] Yes {number} есть в массиве");
else Console.WriteLine($"[{String.Join(", ", array)}] No {number} нет в массиве");