using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_Luke_Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////Question 2 ///////////Luke Fox////////////
            Console.WriteLine("This program will compute the average of ten numbers");
            Console.WriteLine("please enter a number, press enter; do this 10 times and I will tell you your average of each number and total them up as we go");
            int average = 0;
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine();
                average = average + int.Parse(Console.ReadLine());
                Console.Write("your total average so far is {0} ", average / 2);
            }
            

            Console.WriteLine(" we have finished this question");
            Console.ReadLine();



            
        }
    }
}
