
int number = int.Parse(Console.ReadLine());

bool statement = (number >= 100 && number <= 200) || number == 0;

if(!statement)
{
    Console.WriteLine("invalid");
}
