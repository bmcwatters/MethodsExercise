// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("----------");
Console.WriteLine("What is your name?");
var firstName = Console.ReadLine();
Console.WriteLine("Hello " + firstName);
Console.WriteLine("What is your favorite color?");
string color = Console.ReadLine();
Console.WriteLine("Cool, I also like " + color);
Console.WriteLine("What is your favorite animal?");
string animal = Console.ReadLine();
Console.WriteLine("Cool, I also like " + animal);
Console.WriteLine("What is your favorite band?");
string band = Console.ReadLine();
Console.WriteLine("Cool, I also like the " + band);
Console.WriteLine($"Nice to meet you {firstName}, I also like {color}. My favorite animal is also a {animal}");

Console.WriteLine("Give me a number to add");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Give me a second number to add");
int num2 = int.Parse(Console.ReadLine());
int sum = Sum(num1, num2);
Console.WriteLine($"The sum is: {sum}");
Console.WriteLine("Give me a number to multiply");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Give me a second number to multiply");
int y = int.Parse(Console.ReadLine());
int multiply = Multiply(x, y);
Console.WriteLine($"The product is: {multiply}");


static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
    static int Multiply(int x, int y)
    {
        return x * y;
    }