Console. WriteLine("Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N:\n"
                + "M = 1; N = 5 -> 1, 2, 3, 4, 5\n"
                + "M = 4; N = 8 -> 4, 5, 6, 7, 8");
int EnterNumber()
{
    int number;
    bool checkFormat = false;
    do
    {
        Console.Write("Enter number: ");
        checkFormat = int.TryParse(Console.ReadLine(), out number);
    } while (!checkFormat);
    return number;
}
int minNumber = EnterNumber();
int maxNumber = EnterNumber();

string PrintNumber(int minNumber, int maxNumber)
{
    if (minNumber > maxNumber) return "Min > max";
    string numberText = String.Empty;
    if (minNumber == maxNumber) return numberText += minNumber;
    return numberText = minNumber + ", " + PrintNumber(minNumber + 1, maxNumber);
}
Console.WriteLine(PrintNumber(minNumber, maxNumber));
