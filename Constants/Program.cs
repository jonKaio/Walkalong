using System;
/// <summary>
/// This example is exceptionally light weight and barely worth bothering with at this
/// stage.
/// </summary>

namespace Constants
{
    //Not Here
    //public const int Months = 12;
    class Program
    {
        //Here's Okay
        public const int Months = 12;

        //In this example, the constant Months is always 12, and it cannot be changed even
        //the class itself. In fact, when the compiler encounters a constant identifier in
        //C# source code (for example, Months), it substitutes the literal value directly
        //into the intermediate language (IL) code that it produces. Because there is no
        //variable address associated with a constant at run time, const fields cannot be
        //passed by reference and cannot appear as an l-value in an expression.
        //(From Microsofts reference on Constants)

        //l-value in the above annotation refers to the operand on the left hand side of
        //an expression eg LHS = RHS +1
        //LHS is the l-value.


        //But not like this
        //public const int Months;//They need to be initialized at declaration

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EarthYear normalYear = new EarthYear();
            Console.WriteLine($"A normal earth year consists of {normalYear.earthMonths} months");

        }
    }
    class EarthYear
    {
        public int earthMonths = Program.Months;
    }
}
