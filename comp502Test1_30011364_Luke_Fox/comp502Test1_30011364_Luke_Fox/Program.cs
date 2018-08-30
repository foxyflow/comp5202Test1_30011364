using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp502Test1_30011364_Luke_Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////Luke Fox///////////////Question 1//////////
            Console.WriteLine("Q1");
            Console.WriteLine("Enter a whole number between 1 and 1000");
            Console.WriteLine("I will tell you if it is odd or even");

            int userNumber = int.Parse(Console.ReadLine());
            if(userNumber % 2 == 0)
            
                Console.Write("Your number {0}, is EVEN ", userNumber);

            
            else 
            
               Console.WriteLine("your number: {0} is ODD", userNumber);

            
            
            Console.WriteLine( "thank you for playing my app. Goodbye");
            Console.ReadLine();
        }
    }
}
