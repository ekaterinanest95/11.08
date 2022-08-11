// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите номер четверти: ");
int numberOfQquarter = Convert.ToInt32(Console.ReadLine());


if(numberOfQquarter == 1) Console.WriteLine("x > 0 && y > 0");
if(numberOfQquarter == 2) Console.WriteLine("x < 0 && y > 0");
if(numberOfQquarter == 3) Console.WriteLine("x < 0 && y < 0");
if(numberOfQquarter == 4) Console.WriteLine("x > 0 && y < 0");




