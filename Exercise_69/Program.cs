Console.WriteLine("Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии:\n"
                + "A = 3; B = 5 -> 243\n"
                + "A = 2; B = 3 -> 8");
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
int firstNumber = EnterNumber();
int secondNumber = EnterNumber();

int PowNumber(int firstNumber, int secondNumber)
{
    if (secondNumber == 0) return 1;
    if (secondNumber == 1) return firstNumber;
    return firstNumber * PowNumber(firstNumber, secondNumber - 1);
}
Console.WriteLine($"Number {firstNumber} in power {secondNumber} = {PowNumber(firstNumber, secondNumber)}");
