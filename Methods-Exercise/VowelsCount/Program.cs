
string str = Console.ReadLine();

int count = GetVowelsCount(str);

Console.WriteLine(count);

static int GetVowelsCount(string str)
{
    int count = 0;

    for (int i = 0; i <= str.Length - 1; i++)
    {
        char currentSymbol = str[i];

        if(currentSymbol == 'a' || currentSymbol == 'e' || currentSymbol == 'i' || currentSymbol == 'o' || currentSymbol == 'u' ||
            currentSymbol == 'A' || currentSymbol == 'E' || currentSymbol == 'I' || currentSymbol == 'O' || currentSymbol == 'U')
        {
            count++;
        }
    }

    return count;
}
