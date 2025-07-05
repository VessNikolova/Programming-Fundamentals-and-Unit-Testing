
int number = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < number; i++)
{
    int currentNum = int.Parse(Console.ReadLine());

    if (isPrime(currentNum))
    {
        sum += currentNum;
    }
}

Console.WriteLine(sum);

static bool isPrime(int number)
{
    int count = 0;

    for (int i = 1; i <= number; i++)
    {
        if(number % i == 0)
        {
            count++;
        }
    }

    return count == 2;
}
