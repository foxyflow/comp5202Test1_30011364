using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeFox_Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //////Question 3 /////// Luke Fox /////////
            Console.WriteLine("making a simple quadratic using Ax*x + bx + c = 0 ");
            Console.WriteLine("please use whole numbers");

            Console.WriteLine("please enter a number (can be a negitive) (this will be b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("please type and number (can be a negitive) this will be c");
            int c = int.Parse(Console.ReadLine());
            if (c < 0)
                Console.Write($"a*a + {b}x = {0} " + c* -1);
            else if (c > 0)
                Console.Write($"a*a + {b}x = {0} " + c* -1);

            Console.WriteLine("  what are the factors? enter highest factor first");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("what is the smaller factor?");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("these are your factors (x {0})(x {1})", d, e);
            if (b == d - e)
            { Console.WriteLine("your equation is correct (x - {0})(x (+) {1})", e, d);
                Console.WriteLine(" Your starting equation was: Ax*x + {0}x  {1} = {2}", b, c, 0);
            }
            else
                Console.WriteLine("my brain hurts, sorry wrong but don't give up");


            Console.ReadLine();
        }
    }
}
