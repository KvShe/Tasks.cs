// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int number;
bool checkPoint = false;
do
{
    Console.Write("Enter number: ");
    checkPoint = int.TryParse(Console.ReadLine(), out number);
} while (checkPoint == false);
string result = String.Empty;
while(number != 0)
{
    result = Convert.ToString(number % 2) + result;
    number /= 2;
}
Console.WriteLine(result);