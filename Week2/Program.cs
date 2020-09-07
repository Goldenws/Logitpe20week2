using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*Create an app
             *  1.App asks the user's name and greets the users by it's name
             *  2.App asks the user's age and calculates
             *  what year the user was born;
             *  3. App displays the result to the user
             
            
             */
            Console.WriteLine("What's your name");
            string Name;
           Name= Console.ReadLine();
            Console.WriteLine("Oh Hello there, " + Name);
            Console.WriteLine("How old are you");
            string UserInput;
            UserInput = Console.ReadLine();
            int Age; int YearOfBirth;
            //Parsing string of interger (Number)
            YearOfBirth = Int32.Parse(UserInput);
            Age = 2020 - YearOfBirth ;
            Console.WriteLine("You Born in" + Age );
            
        
        
        
        
    
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
