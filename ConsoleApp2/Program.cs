using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.Write("What is your age? ");
        var age = checked ((byte)int.Parse(Console.ReadLine()));
        Console.Write("What is your birthdate? ");
        var birthdate = Console.ReadLine();
        Console.Write($"Nice to meet you, {name}. I know you age is {age} and your birhdate is {birthdate}");


    }
}