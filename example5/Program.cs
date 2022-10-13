Console.WriteLine("Введите число N");
string input = Console.ReadLine();
if (input.Length == 3) {
   System.Console.WriteLine(input[input.Length-1]); 
}
else {
    System.Console.WriteLine("Введите трехзначное число");
}