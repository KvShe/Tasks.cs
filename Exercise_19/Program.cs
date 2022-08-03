// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int number;
bool checkPoint;
do
{
    Console.Write("Enter number: ");
    checkPoint = int.TryParse(Console.ReadLine(), out number);
    checkPoint = number > 9999 && number < 100000;
} while (checkPoint == false);

string numberString = Convert.ToString(number);
if (numberString[0] == numberString[^1] && numberString[1] == numberString[^2]) Console.WriteLine("Yes. This is a palindrom");
else Console.WriteLine("No. This is not a palindrom");