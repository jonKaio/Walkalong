using System;
using System.Collections.Generic;
using System.Text;

namespace RPGWeaponsTest
{
    class Ranged: Weapon
    {
        public int range= 20;
        public int power= 10;

        public Ranged()
        {
            name = "Brittany";
            type = "Single handed spear hits one more time.";
        }

        public Ranged(string _name, string _type, int _age, int _numberOfHands)
        {
            name = _name;
            type = _type;
            age = _age;
            numberHandsRequired = _numberOfHands;
        }



    }
}
