// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int size = 2;
int[] array = new int[size];

Console.Write("Enter coordinate x: ");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinate y: ");
array[1] = Convert.ToInt32(Console.ReadLine());

if (array[0] == 0 || array[1] == 0) Console.WriteLine("Введённое значение вне четвертей");
else if (array[0] > 0 && array[1] > 0) Console.WriteLine("Четверть: 1");
else if (array[0] < 0 && array[1] > 0) Console.WriteLine("Четверть: 2");
else if (array[0] < 0 && array[1] < 0) Console.WriteLine("Четверть: 3");
else Console.WriteLine("Четверть: 4");