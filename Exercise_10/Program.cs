// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

string? number = string.Empty;
do
{
    Console.Write("Enter number: ");
    number = Console.ReadLine();
} while (number.Length < 3 || number.Length > 3);

Console.WriteLine($"Two digit number {number} = {number[1]}");