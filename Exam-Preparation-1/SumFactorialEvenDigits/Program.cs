
int number = int.Parse(Console.ReadLine());

int sum = 0;

while(number > 0)
{
    int currentNum = number % 10;

    if(currentNum % 2 == 0)
    {
        int factorial = GetFactorial(currentNum);
        sum += factorial;
    }

    number /= 10;
}

Console.WriteLine(sum);

static int GetFactorial(int number)
{
    int sum = 1;

    for (int i = number; i > 0; i--)
    {
        sum *= i;
    }

    return sum;
}