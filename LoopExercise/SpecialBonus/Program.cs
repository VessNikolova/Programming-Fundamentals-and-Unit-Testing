
int stopNumber = int.Parse(Console.ReadLine());
int currentNumber = int.Parse(Console.ReadLine());
int lastNumber = 0;

while(currentNumber != stopNumber)
{
    lastNumber = currentNumber;
    currentNumber = int.Parse(Console.ReadLine());
    
}

Console.WriteLine(lastNumber + (lastNumber * 0.2));
