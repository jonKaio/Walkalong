using System;
using System.Collections.Generic;
using System.Text;

namespace Inherit
{
    class Mouse :Animal
    {
        public bool lovesCheese = true;
        public override void Speak()
        {
            Console.WriteLine("Squeek");
        }
    }
}
