// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

int EnterNumber(int number)
{
    bool checkPoint = false;
    do
    {
        Console.Write("Enter length side: ");
        checkPoint = int.TryParse(Console.ReadLine(), out number);
    } while (checkPoint == false);
    return number;
}

int firstSide = 0;  firstSide = EnterNumber(firstSide);
int secondSide = 0; secondSide = EnterNumber(secondSide);
int thirdSide = 0;  thirdSide = EnterNumber(thirdSide);

bool check = (secondSide + thirdSide > firstSide && firstSide + thirdSide > secondSide && firstSide + secondSide > thirdSide);

if (check) Console.WriteLine("Yes. The triangle may exist");
else Console.WriteLine("No. The triangle cannot exist");
