﻿// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите координату по оси ОХ: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси ОY: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0) Console.WriteLine("I четверть");
if(x < 0 && y > 0) Console.WriteLine("II четверть");
if(x < 0 && y < 0) Console.WriteLine("III четверть");
if(x > 0 && y < 0) Console.WriteLine("IV четверть");




