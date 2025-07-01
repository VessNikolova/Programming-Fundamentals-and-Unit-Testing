﻿
int[] arr = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int firstElement = arr[0];

    for (int j = 1; j < arr.Length; j++)
    {
        arr[j - 1] = arr[j];
    }

    arr[arr.Length - 1] = firstElement;
}

Console.WriteLine(String.Join(" ", arr));