Console.WriteLine("Введите число A");
string А = Console.ReadLine();
int numberA = int.Parse(А);
Console.WriteLine("Введите число В");
string B = Console.ReadLine();
int numberB = int.Parse(B);;
if (numberB == numberA * numberA) Console.WriteLine("Да");
else 
{
if (numberA == numberB * numberB) Console.WriteLine("Да");
else Console.WriteLine("Нет");
}


