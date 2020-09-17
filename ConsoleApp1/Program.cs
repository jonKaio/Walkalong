using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pick an item to trade (w1-10 or f1-5 or p1-6 for weapons,food or postions ?");
            string tmpStr = Console.ReadLine();


            //tmpstr could actually be "walk" or "flee" or other commands
            //and in deed it does
            bool inputCommandDealtWith== false;
            switch (tmpStr)
            {
                case "show weapons":
                case "weap":
                case "w":
                    //show weapons
                    //shown the weapons
                    inputCommandDealtWith = true;
                    break;

                default:
                    break;
            }


            if (!inputCommandDealtWith) {
                //tmpStr should equal w1-10 or f1-5 or p1-6
                char c = tmpStr[0];
                switch (c)
                {
                    case 'w':
                        //do the thing for weapons
                        tmpStr = tmpStr.Replace('w', ' ');
                        int tmpInt;
                        int.TryParse(tmpStr, out tmpInt);
                        Console.WriteLine($"You chose to trade weapon number {tmpInt}");
                        Buyandsellweapon("axe", "empty", tmpInt);

                        break;
                    case 'p':
                        //do the same for potions
                        break;
                    default:
                        break;
                }
            }




            Console.WriteLine("Hello World!");
        }

        static void Buyandsellweapon(string _tmp1,string _tmp2,int _index)
        {

        }

    }
}
