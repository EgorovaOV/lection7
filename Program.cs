// собрать строку с числами от a до b, a<b

string NewNum(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NewRec (int a, int b)
{
    if (a<=b) return $"{a} "+ NewRec (a+1, b);
    else return String.Empty;
      
}

Console.WriteLine(NewNum(1, 10));
Console.WriteLine(NewRec(1, 10));

// собрать строку с числами от a до b, a>b
string NewNumm(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NewRecc (int a, int b)
{
    if (a>=b) return $"{a} " + NewRecc(a-1, b);
    else return String.Empty;
      
}

Console.WriteLine(NewNumm(10, 1));
Console.WriteLine(NewRecc(10, 1));