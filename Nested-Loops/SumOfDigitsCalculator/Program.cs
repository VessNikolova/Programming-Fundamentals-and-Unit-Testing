
string input = Console.ReadLine();

while(input != "End")
{
    int number = int.Parse(input);

    int sum = 0;

    while (number > 0)
    {
        int currentDigit = number % 10;

        sum += currentDigit;

        number /= 10;
    }

    Console.WriteLine($"Sum of digits = {sum}");

    input = Console.ReadLine();
}

Console.WriteLine("Goodbye");