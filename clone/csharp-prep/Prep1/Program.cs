using System;

class Program
{
    static void Main(string[] args)
    {
        // asks user their name.
        Console.Write("What is your first name? ");
        string f_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string l_name = Console.ReadLine();
        //user's name is displayed in a last, first last name format.
        Console.WriteLine($"Your name is {l_name}, {f_name} {l_name}.");
    }   
}