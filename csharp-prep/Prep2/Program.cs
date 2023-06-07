using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hey there what's your grade percentage?: ");
        string valueFromInput = Console.ReadLine();
        Console.Beep();

        int a = 100;
        int b = 89;
        int c = 79;
        int d = 69;
        int x = int.Parse(valueFromInput);
        

        
        if (x <= d)
        {
            Console.Write("You got a 'D', put more effort.");
        }
        else if (x <= c)
        {
            Console.Write("You earned a 'C', you passed the class!");
        }
        else if (x <= b)
        {
        Console.Write("That's a 'B', Outstanding!!");
        }
        else if (x <= a)
        {
            Console.Write("An 'A'? Congratulations, you've outdone yourself!!");
        }
        else
        {
            Console.Write("Care to try next semester!!");
            Console.Beep();
             

        }
    }
}