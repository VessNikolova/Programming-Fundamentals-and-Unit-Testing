
int num = Math.Abs(int.Parse(Console.ReadLine()));

int evenSum = GetSumOfEvenDigits(num);
int oddSum = GetSumOfOddDigits(num);

Console.WriteLine(evenSum * oddSum);

static int GetSumOfEvenDigits(int num)
{
    int result = 0;

    while(num > 0)
    {
        int lastDigit = num % 10;

        if(lastDigit % 2 == 0)
        {
            result += lastDigit;
        }

        num /= 10;
    }

    return result;
}

static int GetSumOfOddDigits(int num)
{
    int result = 0;

    while (num > 0)
    {
        int lastDigit = num % 10;

        if (lastDigit % 2 == 1)
        {
            result += lastDigit;
        }

        num /= 10;
    }

    return result;
}
