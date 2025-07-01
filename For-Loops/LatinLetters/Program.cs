
char symbol1 = char.Parse(Console.ReadLine());
char symbol2 = char.Parse(Console.ReadLine());

for (int i = symbol1; i <= symbol2; i++)
{
    Console.Write(System.Convert.ToChar(i) + " ");
}

