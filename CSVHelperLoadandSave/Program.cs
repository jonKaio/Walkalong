using System;
using System.Collections.Generic;

using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;

namespace CSVHelperLoadandSave
{
    struct Role
    {
        string actor;
        string character;

        public string Actor { get => actor; set => actor = value; }
        public string Character { get => character; set => character = value; }
        public Role(string _actor,string _character)
        {
            actor = _actor;
            character = _character;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CSV Helper load and save example!");
            Console.WriteLine("Enter load or create commands to operate");


            string inpCommand = "";
            bool running = true;
            while (running)
            {
                inpCommand = Console.ReadLine().ToLower();
                switch (inpCommand)
                {
                    case "quit":
                        running = false;
                        break;

                    case "show":
                    case "load":
                        {
                            Console.WriteLine("Enter TV show name for this case list");
                            string show = Console.ReadLine();
                            List<Role> showCast = new List<Role>();
                            using (var reader = new StreamReader($"CastList_{show}.csv"))
                            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                            {
                               //Get Records returns an ienumerable 
                               //so as we want to return all of them into a list
                               //we force the ienumerable to do it's thing
                               //and return them all and convert collection 
                               //into a list using ToList
                               showCast = csv.GetRecords<Role>().ToList<Role>();
                            }
                            foreach (Role r in showCast)
                                Console.WriteLine($" {r.Actor} ----  {r.Character}");
                        }


                        break;

                    case "create":
                        {
                            List<Role> showCast = new List<Role>();
                            Console.WriteLine("Enter TV show name for this case list");
                            string show = Console.ReadLine();
                            Console.WriteLine("Now enter an actors name then enter/carriage return and then the character they played.");
                            Console.WriteLine("Repeat as many times as you want.");
                            Console.WriteLine("To save just enter save instead of an actors name");
                            string tmpActor = "";
                            string tmpChar;
                            while (tmpActor.ToLower() != "save")
                            {
                                tmpActor = Console.ReadLine();
                                tmpChar = Console.ReadLine();
                                showCast.Add(new Role(tmpActor, tmpChar));
                            }

                            //Write out the data
                            using (var writer = new StreamWriter($"CastList_{show}.csv"))
                            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                            {
                                csv.WriteRecords(showCast);
                            }

                        }

                        break;
                 


                    default:
                        break;
                }

            }

        }
    }
}
