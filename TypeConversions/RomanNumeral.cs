using System;
using System.Collections.Generic;
using System.Text;

namespace TypeConversions
{
    class RomanNumeral
    {
        private int value;

        static readonly string[] romanDigits =
         { "I","II","III","IV","V","VI","VII","VIII","IX","X","XI","XII","XIII","XIV","XV","XVI","VII","XVIII","XIX","XX","XXI","XXII","XXIII","XXIV","XXX","XL","L","LX","LXX","LXXX","X","C","CI","CII","CC","CCC","CD","D","DC","DCC","DCCC","CM","M","MI","MII","MIII","MCM","MM","MMI","MMII","MMC","MMM","MMMM","V" };


        public RomanNumeral(int value)
        {
            this.value = value;
        }
        // Declare a conversion from an int to a RomanNumeral. Note the
        // the use of the operator keyword. This is a conversion
        // operator named RomanNumeral:
        static public implicit operator RomanNumeral(int value)
        {
            // Note that because RomanNumeral is declared as a struct,
            // calling new on the struct merely calls the constructor
            // rather than allocating an object on the heap:
            return new RomanNumeral(value);
        }
        // Declare an explicit conversion from a RomanNumeral to an int:
        static public explicit operator int(RomanNumeral roman)
        {
            return roman.value;
        }
        // Declare an implicit conversion from a RomanNumeral to
        // a string:
        static public implicit operator string(RomanNumeral roman)
        {
            //our value is stored as an normal integer
            //we need to take that normal integer and convert to a roman numberal string
            string rtnValue = "Conversion not yet implemented";

            if (roman.value-1 <= 20)
                rtnValue = romanDigits[roman.value-1];
                

            
            return rtnValue;


        }
    }
}
