// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)2 + (yb - ya)2

int size = 4;
int[] coordinate = new int[size];
for (int i = 0; i < size; i++)
{
    bool checkPoint;
    do
    {
        Console.Write("Enter number: ");
        checkPoint = int.TryParse(Console.ReadLine(), out coordinate[i]);
    } while (checkPoint == false);
}

double result = Math.Sqrt(Math.Pow((coordinate[2] - coordinate[0]), 2) + Math.Pow((coordinate[3] - coordinate[1]), 2));
Console.WriteLine($"Расстояние между двумя точками = {result:#.##}");
