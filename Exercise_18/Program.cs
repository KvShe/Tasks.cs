// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

bool check;
int quarter;
do
{
    Console.Write("Enter quarter number: ");
    check = int.TryParse(Console.ReadLine(), out quarter);
} while (check == false);

switch (quarter)
{
    case 1:
        Console.WriteLine("x > 0\ny > 0");
        break;
    case 2:
        Console.WriteLine("x < 0\ny > 0");
        break;
    case 3:
        Console.WriteLine("x < 0\ny < 0");
        break;
    case 4:
        Console.WriteLine("x > 0\ny < 0");
        break;
    default:
        Console.WriteLine("Такой четверти не существует");
        break;
}
