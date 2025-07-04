

int[] arr = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int number = int.Parse(Console.ReadLine());

int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < number; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }

    if (arr[i] < min)
    {
        min = arr[i];
    }
}

Console.WriteLine(max);
Console.WriteLine(min);



