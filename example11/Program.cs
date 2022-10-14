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

//if (Math.Pow(A, 2) ==B);  if (Math.Sqrt(B) == A);
//if if (Math.Pow(A, 2) ==B) || (Math.Pow(B, 2) == A);a