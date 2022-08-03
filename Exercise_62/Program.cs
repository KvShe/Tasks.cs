Console.WriteLine("Заполните спирально массив 5 x 5");
int size;
bool checkFormat = false;
do
{
    Console.Write("Enter size array: ");
    checkFormat = int.TryParse(Console.ReadLine(), out size);
} while (!checkFormat || size < 1);
const int cellWidth = 4;
int count = 0;
int[,] array = new int[size, size];
int index = size - 1;
for (int i = 0; i < index; i++)
{
    for (int j = i; j < size - i; j++) array[i, j] = count++;
    for (int j = i + 1; j < index - i; j++) array[j, index - i] = count++;
    for (int j = index - i; j >= 1 + i; j--) array[index - i, j] = count++;
    for (int j = index - i; j >= 1 + i; j--) array[j, i] = count++;
}
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++) Console.Write($"{array[i, j],cellWidth}");
    Console.WriteLine();
}
