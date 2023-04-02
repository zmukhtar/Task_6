using System.Text;
using static System.Math;

namespace Task6_Method_in_Class;

public class Methods
{
    // 1
    public string GetSquareNumber(int i)
{
    var sb = new StringBuilder();
    int  xNumber = 1, yNumber = 1;
      while (yNumber < i)
      {
            sb.Append($"{yNumber} ");
            xNumber += 1;
            yNumber = (xNumber * xNumber);
      }
    return sb.ToString();
}

// 2
public string GetNumberCubed(int aNumber,int bNumber)
{
    var sb = new StringBuilder();
    for (int i = aNumber; i <= bNumber; i++)
     sb.Append($"{i} в кубе = {i*i*i}\n");
    return sb.ToString();
}

// 3
    public string GetExponentiation(double num, int deg)
{
    var sb = new StringBuilder();
    double  res;
    res = 1;
    for (int i = 1; i <= Abs(deg); i++)
    res = res * num;
    if (deg < 0)
    res = 1 / res;
    sb.Append(res.ToString("0.000"));
    return sb.ToString();
}

// 4
    public string GetTableFunction()
{
    var sb = new StringBuilder();
    double x, y;
    x = -5;
    while (x <= 5)
    {
        y = 5 - x * x / 2;
        sb.Append($"{x.ToString("0.0")} | {y.ToString("0.00")}\n");
        x = x + 0.5;
    }
    return sb.ToString();
}

// 5
    public string GetFactorial(int n)
{  
    var sb = new StringBuilder();
    Int64 factorial;
    factorial = 1;
    for (int i = 2; i <= n; i++)
        factorial = factorial * i;
    sb.Append($"n != {factorial}" );
    return sb.ToString();
}

// 6
    public string  GetNumbersFibonachi(int n)
{
    var sb = new StringBuilder();
    int a, b, c;
     a = 0;
    sb.Append($"{a} ");
    b = 1;
    sb.Append($"{b} ");
    for (int i = 3; i <= n; i++)
    {
        sb.Append($"{a+b} ");
        c = b;
        b = a + b;
        a = c;
        
    }   
    return sb.ToString();
}

// 7
    public string GetSeracuz()
{
    var sb = new StringBuilder();
    short n;
    for (short i = 20; i <= 30; i++)
    {
        n = i;
        while ((n<1)||(n>1))
        {
            if ((n%2) == 0)
            n = (short)(n / 2);
            else
            n = (short)((3 * n + 1) / 2); 
            sb.Append($" |{n}|");
        }    
        sb.Append("\n");
    }
    return sb.ToString(); 
}

// 8
    public string GetNumbers(int n)
{
    var sb = new StringBuilder();
    n = Abs(n);
    while (n != 0)
    {
        sb.Append(n % 10);
        n = n / 10;
    }

    return sb.ToString();
} 

    public int GetOneIntKeyboard()
{
    do
    {
        string oneNumberRead = Console.ReadLine();
        bool result = Int32.TryParse(oneNumberRead, out int i);
        if (result)
        {
            return i;
            break;
        }
        Console.WriteLine("Некорректное число.");
    } while (true);
}

    public double GetOneDoubleKeyboard()
{
    do
    { 
        
        string numString = Console.ReadLine();
        bool result = double.TryParse(numString, out double i);
        if (result)
        {
            return i;
            break;
        }
        Console.WriteLine("Некорректное число.");
    } while (true);
}

    public byte GetOneByteKeyboard()
{
    do
    { 
        
        string nString = Console.ReadLine();
        bool result = byte.TryParse(nString, out byte i);
        if (result)
        {
            return i;
            break;
        }
        Console.WriteLine("Некорректное число.");
    } while (true);
    
}

public void Print(object answer)
{
    Console.WriteLine(answer);
}
}