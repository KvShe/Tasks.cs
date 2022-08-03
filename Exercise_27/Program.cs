// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number;
bool checkPoint = false;
do
{
    Console.Write("Enter number: ");
    checkPoint = int.TryParse(Console.ReadLine(), out number);
} while (checkPoint == false);

int sum = 0;
for (int i = 0; number != 0 ; i++)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine($"Сумма цифр = {sum}");
