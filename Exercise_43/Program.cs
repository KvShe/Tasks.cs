// // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1,
// y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем
// k1 = 5
// b1 = 2
// k2 = 9
// b2 = 4
// -> (-0,5; -0,5)

int size = 4;
string[] name = {"k1", "b1", "k2", "b2"};
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    bool checkPoint = false;
    do
    {
        Console.Write($"Enter {name[i]}: ");
        checkPoint = double.TryParse(Console.ReadLine(), out array[i]);
    } while (checkPoint == false);
}
double firstStraight = (array[1] - array[3]) / (array[2] - array[0]);
double secondStraight = array[0] * firstStraight + array[1];
if (array[1] == array[3]) Console.WriteLine("Прямые параллельны");
else Console.WriteLine($"[{secondStraight}; {firstStraight}]");