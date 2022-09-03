using System;

int x, y;
Console.WriteLine("Введите первое число");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
y = Convert.ToInt32(Console.ReadLine());

//int c = x;
//x = y;
//y = c;

x = x - y;
y = x + y;
x = (x-y)*(-1)
Console.WriteLine($"x = {x} y = {y}");