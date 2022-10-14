string input1 = Console.ReadLine();
int A = int.Parse(input1);
string input2 = Console.ReadLine();
int B = int.Parse(input2);
int ost = 0;
if (A%B==0)
{
    System.Console.WriteLine("true");
}
else
{
    ost = A%B;
    if (B%A==0)
    {
        System.Console.WriteLine("true");
    }
    else 
    {
        ost = B%A;  
        System.Console.WriteLine(ost);
    }
}