Random rnd = new Random();
int number = (int)rnd.Next(10,99);
int first = 0;
int second = 0;
first = number / 10;
second = number % 10;
if (first>second){
    System.Console.WriteLine(first);
}
else {
    System.Console.WriteLine(second);
}
