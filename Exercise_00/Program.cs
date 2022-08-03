// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Write("Enter number: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Квадрат числа {number} = {Math.Pow(number, 2)}");