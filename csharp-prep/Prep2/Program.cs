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
            if (x >= 77)
            {
                Console.Write("You got a 'C+', cool.");
            }
            else if (x <= 73)
            {
                Console.Write("You got a 'C-', You can do more.");
            }
            else
            {
                Console.Write("You got a 'C', not bad.");
            }
        }
        else if (x <= b)
        {
            if (x >= 87)
            {
                Console.Write("You got a 'B+', feels good don't it?.");
            }
            else if (x <= 83)
            {
                Console.Write("You got a 'B-', keep at it.");
            }
            else
            {
                Console.Write("You got a 'B', sweet innit.");
            }
        }
        else if (x <= a)
        {
            if (x >= 97)
            {
                Console.Write("You got an 'A+', you're a genius.");
            }
            else if (x <= 93)
            {
                Console.Write("You got an 'A-', Outstanding!!");
            }
            else
            {
                Console.Write("You got an 'A', Proud of ya!!");
            }
        }
        else
        {
            Console.Write("Care to try next semester!!");
            Console.Beep();
        }

        // Create a function that contains a list of students with differnt scores
        // Create a function that takes in a score and returns a grade
        // Create a function that takes in a score and returns a letter grade
        // Create a function that takes in a score and returns a letter grade with + or -
        // Create a function that takes in a score and returns a letter grade with + or - and a message

        // createStudentList();
        // getGrade();
        // getLetterGrade();
        // getLetterGradeWithSign();
        // getLetterGradeWithSignAndMessage();
        
    }
} 