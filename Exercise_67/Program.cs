Console.WriteLine("Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр:\n"
                + "453 -> 12\n"
                + "45 -> 9");
int number;
bool checkFormat = false;
do
{
    Console.Write("Enter number: ");
    checkFormat = int.TryParse(Console.ReadLine(), out number);
} while (!checkFormat);
number = Math.Abs(number);
int SumDigit(int number)
{
    if (number / 10 == 0) return number;
    return number % 10 + SumDigit(number / 10);
}
Console.WriteLine($"Sum digirs of number {number} = {SumDigit(number)}");
