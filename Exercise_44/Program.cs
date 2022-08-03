// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int firstNumber = 0;
int secondNumber = 1;
int number;
bool checkPoint = false;
do
{
    Console.Write("Enter number: ");
    checkPoint = int.TryParse(Console.ReadLine(), out number);
} while (checkPoint == false);
Console.Write($"{firstNumber} ");
Console.Write($"{secondNumber} ");
for (int i = 1; i <= number - 2; i++)
{
    int fibonacci = firstNumber + secondNumber;
    firstNumber = secondNumber;
    secondNumber = fibonacci;
    Console.Write($"{fibonacci} ");
}