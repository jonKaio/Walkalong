using System;
using System.Collections.Generic;
using System.Text;

namespace Inherit
{
    class Dog : Animal
    {
        //public int numberOfLegs = 8;

        public Dog()
        {
            numberOfLegs = 8;
            Console.WriteLine($"A new puppy has been born with {numberOfLegs} legs.");
        }

        public override void Speak()
        {
            Console.WriteLine($"This Puppy Says Woof,Woof I have {numberOfLegs} legs attached to my body.");
        }

    }
}
