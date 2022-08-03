// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int EnterNumber(int number)
{
    bool checkPoint = false;
    do
    {
        Console.Write("Enter number: ");
        checkPoint = int.TryParse(Console.ReadLine(), out number);
    } while (checkPoint == false);
    return number;
}

int size = 0;
Console.Write("Enter length arrays\n");
size = EnterNumber(size);
int[] array = new int[size];
int count = 0;
for (int i = 0; i < size; i++)
{
    array[i] = EnterNumber(array[i]);
    if (array[i] > 0) count++;
}
Console.WriteLine($"[{String.Join(", ", array)}]\n"
                + $"Чисел > 0: {count}");