
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int countNegativeNums = 0;

if(a == 0 || b == 0 && c == 0)
{
    Console.WriteLine("zero");
}
else
{
    if (a < 0)
    {
        countNegativeNums++;
    }

    if (b < 0)
    {
        countNegativeNums++;
    }

    if (c < 0)
    {
        countNegativeNums++;
    }

    if (countNegativeNums % 2 == 0)
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("negative");
    }
}
