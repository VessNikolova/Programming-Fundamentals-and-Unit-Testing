
string password = Console.ReadLine();

if(Contains6To10Char(password) && ConsistsOfLettersAndDigits(password) && ConsistsOf2Digits(password))
{
    Console.WriteLine("Password is valid");
}
else
{
    if (!Contains6To10Char(password))
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }

    if(!ConsistsOfLettersAndDigits(password))
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }

    if(!ConsistsOf2Digits(password))
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}



    static bool Contains6To10Char(string password)
    {
        bool isValid = false;

        if (password.Length >= 6 && password.Length <= 10)
        {
            isValid = true;
        }

        return isValid;
    }

static bool ConsistsOfLettersAndDigits(string password)
{
    foreach (char symbol in password)
    {
        if (!char.IsLetterOrDigit(symbol))
        {
            return false;
        }
    }

    return true;
}

static bool ConsistsOf2Digits(string password)
{
    int count = 0;

    foreach (char symbol in password)
    {
        if (char.IsDigit(symbol))
        {
            count++;
        }
    }

    return count >= 2;
}