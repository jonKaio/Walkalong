


using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace RPGWeaponsTest
{
    class Program
    {
        public static string handedNess = "right";

        static void Main(string[] args)
        {
            Weapon[] myArsenal = SetupWeapons();


            bool gameRunning = true;

            Npc punchingBag = new Npc();

            Npc damsel = new Npc();
            damsel.friend = true;
            damsel.name = "Missy";

            Npc[] charactersInRoom = new Npc[2];
            charactersInRoom[0] = punchingBag;
            charactersInRoom[1] = damsel;
            Prompt("Our First Text RPG Thinggy.");

            handedNess = Ask("Welcome adventurer, are you left or right handed (answer left or right)?\nYou have 5 seconds to answer", 5).ToLower();

            Prompt($"So you are {handedNess} handed.");

            while (gameRunning)
            {
                //Ask player for command and convert to lowercase.
                string command = Ask("What would you like to do ?").ToLower();

                switch (command)
                {
                    case "bag":
                    case "show inv":
                    case "inv":
                    case "inventory":
                        foreach (Weapon weap in myArsenal)
                        {
                            Prompt(weap.name);
                            //do other stuff.
                        }
                        break;

                    case "a":
                    case "att":
                    case "attack":
                        foreach (Weapon weap in myArsenal)
                        {
                            string attackWith = Ask($"Do you want to attack with {weap.name} ?").ToLower();
                            if (attackWith[0] == 'y')
                            {
                                bool didAttack = false;
                                foreach (Npc npc in charactersInRoom)
                                {
                                    if (!npc.friend && npc.hitpoints > 0)
                                    {
                                        didAttack = true;
                                        weap.Attack(npc);
                                        break;
                                    }
                                }
                                if (!didAttack)
                                    Prompt("There wasn't any bad guys left alive to attack.");
                                break;
                            }
                        }

                        break;

                    case "look":
                        Prompt("You are in a room.");
                        if (charactersInRoom.Length > 0)
                        {
                            foreach (Npc npc in charactersInRoom)
                            {
                                Prompt($"You can see that '{npc.name}' is in here with you, and they have {npc.hitpoints} health.");
                            }
                        }

                        break;
                    case "quit":
                        gameRunning = false;
                        break;

                    default:
                        break;
                }







            }


            Prompt($"Thank you for playing.");
        }

        private static Weapon[] SetupWeapons()
        {
            Weapon[] tmpArr = new Weapon[5];
            tmpArr[0] = new Melee();

            tmpArr[1] = new Melee("Excalibur?? the confused sword", "Two Handed Sword", 5, 2);
            tmpArr[2] = new Melee("Short sword", "One Handed Sword", 2);
            tmpArr[3] = new Ranged();

            tmpArr[4] = new Ranged(
                _name: "Super Bow",
                _type: "Enchanted Bow",
                _age: 20,
                _numberOfHands: 2
                );


            return tmpArr;
        }

        public static void Prompt(string _str)
        {
            Console.WriteLine(_str);
        }
        public static string Ask(string _str)
        {
            Prompt(_str);
            return Console.ReadLine();

        }
        /// <summary>
        /// Asks a question and gives the user n seconds to reply.
        /// </summary>
        /// <param name="_str">The text prompt or quesiton to ask</param>
        /// <param name="timeToWait">Number of SECONDS to wait for a reply</param>
        /// <returns></returns>
        public static string Ask(string _str, int timeToWait)
        {
            int checksToPerform = 10;//ie 10 per second
            int checkCounter = 0;
            bool isAnswering = false;
            
            int interval = (timeToWait*1000) / checksToPerform;
            Prompt(_str);
            while (checksToPerform > checkCounter)
            {
                Thread.Sleep(interval);//this allows other things to happen like time continue and the system to take care of life.
                //Then this loop continues to check that things are happening.
                if (Console.KeyAvailable)
                {
                    isAnswering = true;
                    break;
                }
                checkCounter++;
            }
            if (isAnswering)
            {
            
                return Console.ReadLine();
            }
            return "No Comment.";
        }
    }
}
