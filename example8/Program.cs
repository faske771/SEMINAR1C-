Random rnd = new Random();
int number = (int)rnd.Next(100,999);
int first = 0;
int second = 0;
first = number / 100;
second = number % 10;
System.Console.WriteLine(number);
System.Console.Write(first);
System.Console.Write(second);