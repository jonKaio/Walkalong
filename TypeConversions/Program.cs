using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeral numeral;
            numeral = 10;
            // Call the explicit conversion from numeral to int. Because it is
            // an explicit conversion, a cast must be used:
            Console.WriteLine(" (int)numeral= "+ (int)numeral);
            // Call the implicit conversion to string. Because there is no
            // cast, the implicit conversion to string is the only
            // conversion that is considered:
            Console.WriteLine("numeral= "+ numeral);
            // Call the explicit conversion from numeral to int and
            // then the explicit conversion from int to short:
            short s = (short)numeral;
            Console.WriteLine("short s= "+ s);
            Console.ReadKey();

        }
    }
}
