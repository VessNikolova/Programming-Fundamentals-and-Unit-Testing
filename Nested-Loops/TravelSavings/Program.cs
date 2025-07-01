
string input = Console.ReadLine();

while(input != "End")
{
    string destination = input;
    double neededBudget = double.Parse(Console.ReadLine());

    double currentBudget = 0;

    while(currentBudget < neededBudget)
    {
        double money = double.Parse(Console.ReadLine());
        currentBudget += money;

        Console.WriteLine($"Collected: {currentBudget:F2}");
    }

    Console.WriteLine($"Going to {destination}!");

    currentBudget = 0;

    input = Console.ReadLine();
}


