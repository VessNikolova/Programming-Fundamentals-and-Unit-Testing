
double depositedAmount = double.Parse(Console.ReadLine());
int termInMonths = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double accumulatedInterest = depositedAmount * (annualInterestRate / 100);
double monthlyInterest = accumulatedInterest / 12;
double amount = depositedAmount + termInMonths * monthlyInterest;

Console.WriteLine($"{amount:F2}");

