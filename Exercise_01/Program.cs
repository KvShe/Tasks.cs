// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Write("Enter number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == Math.Pow(secondNumber, 2)) Console.WriteLine($"Yes: {secondNumber} - квадрат {firstNumber}");
else Console.WriteLine($"No: {secondNumber} - не квадрат {firstNumber}");