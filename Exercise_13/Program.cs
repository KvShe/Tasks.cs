// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter number: ");
string? number = Console.ReadLine();
if (number.Length > 2) Console.WriteLine($"Digit №3 number {number}: {number[2]}");
else Console.WriteLine($"Digit №3 number {number}: none");