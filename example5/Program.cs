//Console.WriteLine("Введите число N");
//string input = Console.ReadLine();
//if (input.Length == 3) {
//   System.Console.WriteLine(input[input.Length-1]); 
//}
//else {
//   System.Console.WriteLine("Введите трехзначное число");
//}

Console.WriteLine("Введите число N");
string input = Console.ReadLine();
int A = int.Parse(input);
//int kkk = A%10;
//Console.WriteLine(kkk);1

if (A>=100 && A<=999)
{
    int kkk = A%10;
    Console.WriteLine(kkk);
}
else
{
    Console.WriteLine("Введите трехзначное число");
}