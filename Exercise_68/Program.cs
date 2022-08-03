Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n:\n"
                + "m = 2, n = 3 -> A(m, n) = 29\n"
                + "m = 3, n = 2 -> A(m, n) = 9");
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

int Ackermann(int firstNumber, int secondNumber)
{
    if (firstNumber == 0) return secondNumber + 1;
    if (firstNumber > 0 && secondNumber == 0) return Ackermann(firstNumber - 1, 1);
    return Ackermann(firstNumber - 1, Ackermann(firstNumber, secondNumber - 1));
}
Console.WriteLine($"Ackermann({firstNumber}, {secondNumber}) = {Ackermann(firstNumber, secondNumber)}");
