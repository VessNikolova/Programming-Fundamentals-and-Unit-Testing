
int baseNumber = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

Console.WriteLine(MathPower(baseNumber, power));

static int MathPower(int baseNumber, int power)
{
    int result = 1;

    for (int i = 0; i < power; i++)
    {
        result *= baseNumber;
    }

    return result;
}
