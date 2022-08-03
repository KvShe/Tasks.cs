// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = Math.Max(firstNumber, secondNumber);
max = Math.Max(max, thirdNumber);

Console.WriteLine($"Max = {max}");