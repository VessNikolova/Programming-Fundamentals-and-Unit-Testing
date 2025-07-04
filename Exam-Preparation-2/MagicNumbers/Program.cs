

int number = int.Parse(Console.ReadLine());

bool found = false;

for (int i = 1; i <= number; i++)
{
    int sum = 0;
    int newNum = i;
    bool allDigitsPrime = true;

    while (newNum > 0)
    {
        int currentDigit = newNum % 10;

        if (!IsPrime(currentDigit))
        {
            allDigitsPrime = false;
            break;
        }

        sum += currentDigit;
        newNum /= 10;

    }

    if (sum % 2 == 0 && allDigitsPrime)
    {
        Console.Write(i + " ");
        found = true;
    }
}


if (!found)
{
    Console.WriteLine("no");
}

static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number <= 3) return true;
    if (number % 2 == 0 || number % 3 == 0) return false;

    for (int j = 5; j * j <= number; j = j + 6)
    {
        if (number % j == 0 || number % (j + 2) == 0)
            return false;
    }

    return true;
}
