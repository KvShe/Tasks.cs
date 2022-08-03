// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber) Console.WriteLine($"Max = {firstNumber}\nMin = {secondNumber}");
else Console.WriteLine($"Max = {secondNumber}\nMin = {firstNumber}");
