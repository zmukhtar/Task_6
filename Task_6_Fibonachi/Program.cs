// See https://aka.ms/new-console-template for more information
int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;
     
    return Fibonachi(n - 1) + Fibonachi(n - 2);
}
 
int fibonachi = Fibonachi(5);
Console.WriteLine(fibonachi);
