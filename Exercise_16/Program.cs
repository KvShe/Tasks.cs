// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//  5,   25 ->  да
//  -4,  16 ->  да
//  25,  5  ->  да
//  8,   9  ->  нет

Console.Write("Enter number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

if (firstNumber == Math.Pow(secondNumber, 2)) Console.WriteLine($"Yes. {firstNumber} is the square of {secondNumber}");
else if (secondNumber == Math.Pow(firstNumber, 2)) Console.WriteLine($"Yes. {secondNumber} is the square of {firstNumber}");
else Console.WriteLine("No");