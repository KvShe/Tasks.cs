Console.WriteLine($"Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N\n"
                + $"M = 1; N = 5. -> 1, 2, 3, 4, 5\n"
                + $"M = 4; N = 8. -> 4, 6, 7, 8");
int EnterNumber()
{
    int number;
    bool checkFormat = false;
    do
    {
        Console.Write("Enter number: ");
        checkFormat = int.TryParse(Console.ReadLine(), out number);
    } while (!checkFormat || number < 1);
    return number;
}
int minNumber = EnterNumber();
int maxNumber = EnterNumber();

string PrintNumber(int min, int max)
{
    string numberText = String.Empty;
    if (min > max) return "Min > max";
    if (min == max) return numberText = Convert.ToString(min);
    return numberText = min + ", " + PrintNumber(min + 1, max);
}
Console.WriteLine(PrintNumber(minNumber, maxNumber));
