using System;
using System.Collections.Generic;
using System.Text;

namespace RPGWeaponsTest
{
    class Npc
    {
        public string name = "A Nameless One";
        public bool friend = false;
        public int hitpoints = 5;

        public void HealthCheck()
        {
            if (hitpoints <= 0)
                Program.Prompt($"{name} had died.");
            else
                Program.Prompt($"{name} is holding on to life.");
            
        }
    }
}
