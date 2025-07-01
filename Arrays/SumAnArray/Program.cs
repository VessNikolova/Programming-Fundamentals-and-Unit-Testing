

int[] values = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int sum = 0;

for (int i = 0; i < values.Length; i++)
{

    sum += values[i];
}

Console.WriteLine(sum);
