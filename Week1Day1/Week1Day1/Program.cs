using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Explorer Mode
            //Using the appropriate data types in c# create the following variables:

            //a variable that holds the string "Hello World"
            string string1 = ("Hello World");

            //a variable that holds the number 1492
            int int1 = 1492;

            //a variable that holds if you have a dog at home
            bool dogAtHome = true;

            //a variable that holds today's date as a string
            DateTime myDateTime = DateTime.UtcNow;
            

            //a variable that holds the amount of $5.45
            double myDouble = 5.45;
           

            //a variable that holds the single letter X
            string string3 = ("X");


            //Let's practice string interpolation, by writing the following the strings to the console:
            //"Hello World"(using the variable from #1 above)
            Console.WriteLine(string1);

            //"Columbus Sailed the world in 1492."(using the variable from #2 above)
            Console.WriteLine("Columbus Sailed the world in " + int1);

            //"It is true that I have a dog at home."(using the variable from #3 above)
            Console.WriteLine("It is " + dogAtHome.ToString().ToLower() + " that I have a dog at home.");

            //"Today is 2/29/2016."(using the variable from #4 above)
            Console.WriteLine("Today is " + myDateTime);

            //"I spent $5.45 on a cheeseburger."(using the variable from #5 above)
            Console.WriteLine("I spent " + myDouble.ToString("C") + " on a cheeseburger.");

            //"X marks the spot"(using the variable from #6 above)
            Console.WriteLine(string3 + " marks the spot.");

            Console.ReadLine();
        }
    }
}
