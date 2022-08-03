Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N:\n"
                + "M = 1; N = 15 -> 120\n"
                + "M = 4; N = 8. -> 30");
int EnterNumber()
{
    int number;
    bool checkFormat = false;
    do
    {
        Console.Write("Enter number: ");
        checkFormat = int.TryParse(Console.ReadLine(), out number);
    } while (!checkFormat || number < 0);
    return number;
}
int minNumber;
int maxNumber;
do
{
    minNumber = EnterNumber();
    maxNumber = EnterNumber();
    if (minNumber > maxNumber) Console.WriteLine("Min < max");
} while (minNumber > maxNumber);
int SumNumber(int minNumber, int maxNumber)
{
    if (minNumber == maxNumber) return minNumber;
    return minNumber + SumNumber(minNumber + 1, maxNumber);
}
Console.WriteLine($"{SumNumber(minNumber, maxNumber)}");
