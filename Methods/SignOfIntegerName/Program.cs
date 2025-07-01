
int num = int.Parse(Console.ReadLine());

PrintNumberSign(num);

static void PrintNumberSign(int number)
{
    if(number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }else if(number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else
    {
        Console.WriteLine($"The number {number} is zero.");
    }
}