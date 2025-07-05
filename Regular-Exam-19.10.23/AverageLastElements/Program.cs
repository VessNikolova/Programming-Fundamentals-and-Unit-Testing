
int[] arr = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int number = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = arr.Length - 1; i >= arr.Length - number; i--)
{
    sum += arr[i];
}

double averageSum = sum / number;

Console.WriteLine($"{averageSum:F2}");
