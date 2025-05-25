
int score = int.Parse(Console.ReadLine());

if(score >= 0 && score <= 3)
{
    Console.WriteLine(score + 5);
}else if(score >= 4 && score <= 6)
{
    Console.WriteLine(score + 15);
}else if(score >=7 && score <= 9)
{
    Console.WriteLine(score + 20);
}