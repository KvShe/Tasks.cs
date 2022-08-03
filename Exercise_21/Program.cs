// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// √(xb - xa)2 + (yb - ya)2 + (zb - za)2

int size = 6;
int[] coordinate = new int[size];
bool checkPoint = false;
for (int i = 0; i < size; i++)
{
    do
    {
        Console.Write("Enter coordinate: ");
        checkPoint = int.TryParse(Console.ReadLine(), out coordinate[i]);
    } while (checkPoint == false);
}

double result = Math.Sqrt(Math.Pow((coordinate[3] - coordinate[0]), 2) + Math.Pow((coordinate[4] - coordinate[1]), 2) + Math.Pow((coordinate[5] - coordinate[2]), 2));
Console.WriteLine($"Расстояние между двумя точками = {result:#.##}");