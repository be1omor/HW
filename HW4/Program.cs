﻿Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;

while(i<a)
{
    Console.Write($"{i} ");
    i=i+2;
}
