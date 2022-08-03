// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10, 100);
int digitOne = number / 10;
int digitTwo = number % 10;

if (digitOne > digitTwo) Console.WriteLine($"Max digit random number {number} = {digitOne}");
else Console.WriteLine($"Max digit random number {number} = {digitTwo}");