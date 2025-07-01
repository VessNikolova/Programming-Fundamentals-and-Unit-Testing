
using System.Globalization;

List<int> items = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string[] input = Console.ReadLine().Split();

int bombNumber = int.Parse(input[0]);
int bombPower = int.Parse(input[1]);

while (items.Contains(bombNumber))
{
    int bombIndex = items.IndexOf(bombNumber);

    int start = bombIndex - bombPower;
    int end = bombIndex + bombPower;

    if(start < 0)
    {
        start = 0;
    }

    if(end >= items.Count)
    {
        end = items.Count - 1;
    }

    for (int i = start; i <= end; i++)
    {
        items[i] = 0;
    }
}

Console.WriteLine(items.Sum());

