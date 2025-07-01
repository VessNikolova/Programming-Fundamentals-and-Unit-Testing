
int num = int.Parse(Console.ReadLine());
int currentNum = num;

bool isSpecial = true;

while(num > 0)
{
    int digit = num % 10;

    if(currentNum % digit != 0)
    {
        isSpecial = false;
        break;
    }

    num = num / 10;
}

if(isSpecial)
{
    Console.WriteLine(currentNum + " is special");
}
else
{
    Console.WriteLine(currentNum + " is not special");
}
