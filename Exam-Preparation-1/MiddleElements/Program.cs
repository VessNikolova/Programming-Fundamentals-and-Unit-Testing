
using System.Net.Sockets;

int[] arr = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int middleIndex = arr.Length / 2;

double result = (arr[middleIndex] + arr[middleIndex - 1]) / 2.0;

Console.WriteLine($"{result:F2}");


