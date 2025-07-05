
int[] arr = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int number = int.Parse(Console.ReadLine());

foreach (var item in arr)
{
    if(item > number)
    {
        Console.Write(item + " ");
    }
}
