using System;
using System.Collections.Generic;
using System.Text;

namespace Inherit
{
    class Animal
    {
        public int numberOfLegs = 4;

        public virtual void Speak()
        {
            Console.WriteLine("Mumble");
        }
    }
}
