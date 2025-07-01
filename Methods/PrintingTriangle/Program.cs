
int num = int.Parse(Console.ReadLine());

PrintTriangle(num);

static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static void PrintTriangle(int num)
{
    for (int i = 1; i <= num; i++)
    {
        PrintLine(1, i);
    }

    for (int i = num-1; i >= 1; i--)
    {
        PrintLine(1, i);
    }
}
