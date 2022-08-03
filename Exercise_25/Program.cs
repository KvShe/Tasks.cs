// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

int firstNumber = 0;
firstNumber = EnterNumber(firstNumber);
int secondNumber = 0;
do
{
    secondNumber = EnterNumber(secondNumber);
} while (secondNumber < 1);
Console.WriteLine($"{firstNumber} в степени {secondNumber} = {Math.Pow(firstNumber, secondNumber)}");
