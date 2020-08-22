using System;
using System.Collections.Generic;
using System.Text;

namespace RPGWeaponsTest
{
    class Weapon
    {
        public string name;
        public string type;
        public int age=20;
        public string fluff ="Lots of description text";
        public int damage=1;
        public int hitPoints = 10;
        public int numberHandsRequired = 1;
        public int damageModifier = 0;

        public virtual void Attack(Npc npc)
        {
            npc.hitpoints-=damage;
            Console.WriteLine($"You bludgeon the '{npc.name}' for {damage} point(s) of damage.");
            npc.HealthCheck();
        }
    }
}
