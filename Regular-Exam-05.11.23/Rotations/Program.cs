
int[] arr = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    int lastItem = arr[arr.Length - 1];

    for (int j = arr.Length - 1; j > 0; j--)
    {
        arr[j] = arr[j - 1];
    }

    arr[0] = lastItem;
}

Console.WriteLine(String.Join(", ", arr));
