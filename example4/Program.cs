Console.WriteLine("Введите число N");
string N = Console.ReadLine();
int Number = int.Parse(N);
int Number2 = Number * (-1);
while (Number2<Number)
{
    Console.Write(Number2);
    Number2++;
}
