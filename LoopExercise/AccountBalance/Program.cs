
string input = Console.ReadLine();

double balance = 0;

while (input != "End")
{

    double transaction = double.Parse(input);
    if(transaction > 0)
    {
        balance += transaction;
        Console.WriteLine($"Increase: {transaction:F2}");
    }
    else
    {
        balance += transaction;
        Console.WriteLine($"Decrease: {Math.Abs(transaction):F2}");
    }
    
    input = Console.ReadLine();
}

Console.WriteLine($"Balance: {balance:F2}");