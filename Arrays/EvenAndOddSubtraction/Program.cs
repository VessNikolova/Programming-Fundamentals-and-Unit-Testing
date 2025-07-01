
int[] arr = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int sumEven = 0;
int sumOdd = 0;

foreach (int item in arr)
{
    if(item % 2 == 0)
    {
        sumEven += item;
    }
    else
    {
        sumOdd += item;
    }
}

Console.WriteLine(sumEven - sumOdd);
