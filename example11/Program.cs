int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
if (A*A == B)
{
    System.Console.WriteLine("true");
}
else
{
    if (B*B == A)
    {
        System.Console.WriteLine("true");
    }
    else
    {
    System.Console.WriteLine("false");
    }
}