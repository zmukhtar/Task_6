// See https://aka.ms/new-console-template for more information
string s = "";
var summ =Summ(110, 220);

Console.WriteLine($"{summ.Item1} + {summ.Item2} = {summ.Item3}");

static (int, int, string) Summ(int a,int b)
{
    int c = a + b;

    string s = c.ToString();
    return(a, b, s);
    
}