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
            Console.WriteLine($"This Animal Says Mumble,Mumble I have {numberOfLegs} legs attached to my body.");
        }

        public int AddTwoInts(int _lhs, int _rhs)
        {
            return _lhs + _rhs;
        }
    }
}
