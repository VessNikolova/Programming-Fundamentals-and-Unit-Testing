
int num = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= num; i++)
{
    Console.Write(i);

    sum += i;

    if(i < num)
    {
        Console.Write("+");
    }

}

Console.Write($"={sum}");
