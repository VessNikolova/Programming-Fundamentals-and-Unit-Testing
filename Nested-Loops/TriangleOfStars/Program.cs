﻿
int num = int.Parse(Console.ReadLine());

for (int i = 1;  i <= num; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");  
    }

    Console.WriteLine();
}
