﻿Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите t: ");
double t = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите e: ");
double e = Convert.ToDouble(Console.ReadLine());
double P = (Math.Pow(Math.Sin(x), 3) + Math.Log(2 * y + 3 * x)) / (Math.Pow(t, e) + Math.Sqrt(x));
Console.WriteLine($"P = {P:F2}");