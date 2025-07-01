string type = Console.ReadLine();
string element1 = Console.ReadLine();
string element2 = Console.ReadLine();

CompareTwoValues(type, element1, element2);

static void CompareTwoValues(string? type, string? element1, string? element2)
{
    if(type == "int")
    {
        int a = int.Parse(element1);
        int b = int.Parse(element2);

        Console.WriteLine(CompareTwoInteger(a,b));
    }else if(type == "char")
    {
        char a = char.Parse(element1);
        char b = char.Parse(element2);

        Console.WriteLine(CompareTwoChars(a,b));
    }else if(type == "string")
    {
        Console.WriteLine(CompareTwoStrings(element1, element2));
    }
}

static string CompareTwoStrings(string? a, string? b)
{
    int result = a.CompareTo(b);

    if (result > 0)
        return a;
    else
        return b;
}

static char CompareTwoChars(char a, char b)
{
    if(a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

static int CompareTwoInteger(int a, int b)
{
    if(a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}