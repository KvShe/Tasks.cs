// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

int number;
bool checkPoint = false;
do
{
    Console.Write("Enter number: ");
    checkPoint = int.TryParse(Console.ReadLine(), out number);
} while (checkPoint == false);

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"Куб от {i} = {Math.Pow(i, 3)}");
}