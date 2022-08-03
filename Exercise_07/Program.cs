// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int number;
do
{
    Console.Write("Enter number: ");
    number = Convert.ToInt32(Console.ReadLine());
} while (number < 100 || number > 999);

Console.WriteLine($"Последняя цифра, числа {number} - {number % 10}");
