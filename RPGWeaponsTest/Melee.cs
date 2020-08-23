using System;
using System.Collections.Generic;
using System.Text;

namespace RPGWeaponsTest
{
    class Melee : Weapon
    {
        public string eg = "kjgaksjhgjkhasdgkuygsdfuigusdg";
        public Melee()
        {
            this.name = "Rusty Gimble the one handed axe";
            this.type = "Axe";
            this.damageModifier = -2;
            this.damage = 2;
        }

        public Melee(string _name, string _type, int _damagModifier)
        {
            this.name = _name;
            this.type = _type;
            this.damageModifier = _damagModifier;
            this.damage = 2;
        }
        public Melee(string _name, string _type, int _damagModifier, int _numberOfHands)
        {
            this.name = _name;
            this.type = _type;
            this.damageModifier = _damagModifier;
            this.numberHandsRequired = _numberOfHands;
            this.damage = 2;
        }

        public override void Attack(Npc npc)
        {
            //my own thing here
            string swing = Program.Ask("Do you swing from the left or the right ?").ToLower();
            int tmpDamage = damage;
            if (swing == Program.handedNess)
                tmpDamage *= 2;

            npc.hitpoints -= tmpDamage;
            Program.Prompt($"You swung and did {tmpDamage} point of damage to '{npc.name}'");
            npc.HealthCheck();
        }



    }
}
