
int num = int.Parse(Console.ReadLine());
int count2 = 0;
int count3 = 0;
int count4 = 0;


for (int i = 0; i < num; i++)
{
    int currentNum = int.Parse(Console.ReadLine());

    if(currentNum % 2 == 0)
    {
        count2++;
    } 
    if(currentNum % 3 == 0)
    {
        count3++;
    }
    
    if(currentNum % 4 == 0)
    {
        count4++;
    }
}

double percentDivisible2 = (count2 * 1.0 / num) * 100;
double percentDivisible3 = (count3 * 1.0 / num) * 100;
double percentDivisible4 = (count4 * 1.0 / num) * 100;

Console.WriteLine($"{percentDivisible2:F2}%");
Console.WriteLine($"{percentDivisible3:F2}%");
Console.WriteLine($"{percentDivisible4:F2}%");
