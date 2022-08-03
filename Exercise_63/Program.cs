Console.WriteLine($"Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N\n"
                + $"N = 5 -> 1, 2, 3, 4, 5\n"
                + $"N = 6 -> 1, 2, 3, 4, 5, 6");
int number;
bool checkFormat = false;
do
{
    Console.Write("Enter number: ");
    checkFormat = int.TryParse(Console.ReadLine(), out number);
} while (!checkFormat || number < 1);

string PrintNumber(int number)
{
    string numberText = String.Empty;
    if(number == 1) return "1";
    return numberText = PrintNumber(number - 1) + ", " + number + numberText;
}
Console.WriteLine(PrintNumber(number));
