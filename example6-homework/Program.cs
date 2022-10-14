Console.WriteLine("Введите число A");
string A = Console.ReadLine();
int Ac = int.Parse(A);
Console.WriteLine("Введите число B");
string B = Console.ReadLine();
int Bc = int.Parse(B);
int max = 0;
int min = 0;
if (Ac == Bc)
{
    Console.WriteLine("A = B");
}
else
{
    if (Ac > Bc)
    {
        max = Ac;
        min = Bc;
    }
    else
    {
        max = Bc;
        min = Ac;
    }
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}