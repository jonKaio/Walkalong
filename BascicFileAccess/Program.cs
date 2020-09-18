using System;
using System.IO;

namespace BascicFileAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string inpCommand = "";
            bool running = true;
            while (running)
            {
                Console.WriteLine("Enter Command>");
                inpCommand = Console.ReadLine().ToLower();

                switch (inpCommand)
                {
                    case "create":
                        Console.WriteLine("Enter FileName>");
                        string fName = Console.ReadLine();
                        string lineEnter = "";
                        Console.WriteLine("Enter data for textfile line by line, enter 'quit' to end");
                        using (var myFile = new StreamWriter(fName))
                        {
                            while (lineEnter != "quit")
                            {
                                lineEnter = Console.ReadLine();
                                if (lineEnter != "quit")
                                    myFile.WriteLine(lineEnter);
                            }
                        }
                        Console.WriteLine($"File saved as {fName}");

                            break;
                    case "delete":
                        break;
                    case "read":
                    default:
                        break;
                }



            }



        }
    }
}
