using System;
using System.Collections.Generic;
using System.Text;

namespace Inherit
{
    abstract class Insect
    {
        public abstract void SayName();
    }

    class Spider : Insect
    {
        public override void SayName()
        {
            Console.WriteLine("Cyril the Spider");
        }
    }

}
