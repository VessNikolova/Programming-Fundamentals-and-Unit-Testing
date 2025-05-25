
double firstNum = double.Parse(Console.ReadLine());
double secondNum = double.Parse(Console.ReadLine()); ;
string symbol = Console.ReadLine();

double result = 0;

if (symbol == "+")
{
    result = firstNum + secondNum;
}
else if(symbol ==  "-")
{
    result = firstNum - secondNum;
}
else if(symbol == "*")
{
    result = firstNum * secondNum;
}else if(symbol == "/")
{
    result = firstNum / secondNum;
}

Console.WriteLine($"{firstNum} {symbol} {secondNum} = {result:F2}");
