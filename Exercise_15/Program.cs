// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

byte number;
do
{
    Console.Write("Enter number: ");
    number = Convert.ToByte(Console.ReadLine());
} while (number < 1 || number > 7);
if (number > 5) Console.WriteLine("This is a holiday");
else Console.WriteLine("This is a weekday");