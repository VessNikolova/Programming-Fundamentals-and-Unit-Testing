
string str = Console.ReadLine();
int num = int.Parse(Console.ReadLine());

string repeatedText = printRepeatedText(str, num);

Console.WriteLine(repeatedText);

static string printRepeatedText(string str, int num)
{
    string text = "";

    for (int i = 0; i < num; i++)
    {
        text += str;
    }

    return text;
}
